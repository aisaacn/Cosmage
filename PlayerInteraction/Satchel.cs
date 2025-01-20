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
        public List<Essence> Essences { get { return AllItems.OfType<Essence>().ToList(); } }
        public List<Catalyst> Catalysts { get { return AllItems.OfType<Catalyst>().ToList(); } }
        public List<Consumable> Consumables { get { return AllItems.OfType<Consumable>().ToList(); } }
        public List<PassiveItem> PassiveItems { get { return AllItems.OfType<PassiveItem>().ToList(); } }
        public int TotalWeight // TODO this might be overcomplicating it. Maybe just keep a running total
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
        //private int currentWeight;
        //private int maxWeight; // TODO probably shouldn't be Satchel's responsibility to care about max Satchel size
        public Satchel()
        {
            AllItems = new List<Item>();
        }

        public Satchel(List<Item> items)
        {
            AllItems = items;
        }

        public void AddItem(Item item)
        {
            AllItems.Add(item);
        }

        public bool RemoveItem(Item item)
        {
            return AllItems.Remove(item);
        }


        //public bool AddItem(Item itemToAdd)
        //{
        //    if (currentWeight + itemToAdd.SatchelWeight > maxWeight) return false;

        //    AllItems.Add(itemToAdd);
        //    currentWeight += itemToAdd.SatchelWeight;
        //    return true;
        //}
    }
}
