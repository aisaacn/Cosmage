using CosmageV2.PlayerInteraction.Itemization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Serialization
{
    public class PlayerSerializable
    {
        public string Name { get; set; }
        public Element Element { get; set; }
        public List<Item> Items { get; set; }

        [JsonConstructor]
        public PlayerSerializable(string name, Element element, List<Item> items)
        {
            Name = name;
            Element = element;
            Items = items;
        }

        public PlayerSerializable(Player player)
        {
            Name = player.Name;
            Element = player.Element;
            Items = new List<Item>(player.Satchel.AllItems); // TODO may need further attention to prevent reference issues
        }
    }
}
