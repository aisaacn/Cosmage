using CosmageV2.PlayerInteraction.Itemization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Reflection;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Serialization
{
    public class ItemFlyweightJsonConverter : JsonConverter<Item>
    {
        public override Item Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException("Expected StartObject");

            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            var root = jsonDoc.RootElement;

            if (!root.TryGetProperty("itemType", out var typeProperty))
                throw new JsonException("Missing itemType discriminator");

            var typeStr = typeProperty.GetString();

            // Use reflection to search through ItemRegistry for matching flyweight
            var registryTypes = new[]
            {
            typeof(ItemRegistry.Essences),
            typeof(ItemRegistry.Catalysts),
            typeof(ItemRegistry.Consumables),
            typeof(ItemRegistry.PassiveItems)
        };

            foreach (var registryType in registryTypes)
            {
                var foundItem = FindFlyweightItem(registryType, typeStr);
                if (foundItem != null)
                    return foundItem;
            }

            throw new JsonException($"No flyweight found for item type: {typeStr}");
        }

        public override void Write(Utf8JsonWriter writer, Item value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("itemType", value.GetType().Name);
            writer.WriteEndObject();
        }

        private Item FindFlyweightItem(Type registryType, string typeName)
        {
            return registryType
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f => f.FieldType.BaseType == typeof(Item) ||
                        f.FieldType.BaseType?.BaseType == typeof(Item))
                .FirstOrDefault(f =>
                    string.Equals(f.Name, typeName, StringComparison.OrdinalIgnoreCase))
                ?.GetValue(null) as Item;
        }
    }
}
