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
        public int TotalWeight => AllItems.Sum(item => item.SatchelWeight);

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

        public Satchel Clone()
        {
            Satchel newSatchel = new Satchel();
            foreach (Item item in AllItems)
            {
                newSatchel.AddItem(item);
            }
            return newSatchel;
        }
    }
}
