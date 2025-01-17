using CosmageV2.PlayerInteraction.Itemization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    public class Satchel
    {
        public List<Item> AllItems { get; private set; }
        public List<Ingredient> Ingredients { get { return AllItems.OfType<Ingredient>().ToList(); } }
        public List<Consumable> Consumables { get { return AllItems.OfType<Consumable>().ToList(); } }
        public List<PassiveItem> PassiveItems { get { return AllItems.OfType<PassiveItem>().ToList(); } }
        public int TotalWeight 
        {
            get
            {
                int weight = 0;
                foreach (Item item in AllItems)
                {
                    weight += item.SatchelWeight;
                }
                return weight;
            }
        }

        public Satchel()
        {
            AllItems = new List<Item>();
        }
    }
}
