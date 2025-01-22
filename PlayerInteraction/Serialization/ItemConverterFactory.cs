using CosmageV2.PlayerInteraction.Itemization;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CosmageV2.PlayerInteraction.Serialization
{
    public class ItemConverterFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            throw new NotImplementedException();
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        private class ItemConverter : JsonConverter<Item>
        {
            public override Item Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override void Write(Utf8JsonWriter writer, Item value, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
        }
    }
}
