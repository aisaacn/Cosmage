using CosmageV2.PlayerInteraction.Itemization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Serialization
{
    public class PlayerSerializable
    {
        public string Name { get; set; }
        public Element Element { get; set; }
        public List<Item> Items { get; set; } = [];
    }
}
