using CosmageV2.GamePhase;
using CosmageV2.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmageV2.PlayerInteraction
{
    internal class Player
    {
        public Element Element { get; }
        public string Name { get; }
        public int Health { get; private set; }
        public List<Construct> Constructs { get; private set; }
        ElementalStrength cauldron;

        public Player(Element element, string name) 
        {
            Element = element;
            Name = name;
            Health = 20; //TODO: abstract health for different rulesets
            cauldron = new ElementalStrength();
            Constructs = new List<Construct>();
        }

        public void HandleAddIngredient()
        {
            // TODO await input from GUI
            Console.WriteLine($"Adding ingredient to {Name}'s Cauldron");
            cauldron.AddStrength(Element, 1);
            Console.WriteLine($"{Name}'s current Cauldron: {cauldron}");
        }

        public void HandleUseConsumables()
        {
            // TODO implement user interaction (consumables will simply modify cauldron for now)
            Console.WriteLine($"{Name} may use any number of consumables");
        }

        public void HandleRuneActivation()
        {
            // TODO implement rune system
            Console.WriteLine($"{Name} may add one charge to and activate a single rune");
        }

        public bool IsSpellReadyToCast()
        {
            // TODO rune system
            return false;
        }
    }
}
