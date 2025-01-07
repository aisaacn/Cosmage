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
        CatalystType catalyst;

        IAddIngredientHandler addIngredientHandler;

        public Player(Element element, string name) 
        {
            Element = element;
            Name = name;
            Health = 20; //TODO: abstract health for different rulesets

            Constructs = new List<Construct>();
            cauldron = new ElementalStrength();
            catalyst = CatalystType.None;

            addIngredientHandler = new WinFormAddIngredientHandler();
        }

        public void HandleAddIngredient()
        {
            // TODO abstract this to something like IIngredientPhaseHandler
            addIngredientHandler.HandleAddIngredient(this);
            Console.WriteLine($"{Name}'s current Cauldron: {cauldron}");
        }

        public void HandleUseConsumables()
        {
            // TODO implement user interaction (consumables will simply modify cauldron for now)
            // Console.WriteLine($"{Name} may use any number of consumables");
        }

        public void HandleRuneActivation()
        {
            // TODO implement rune system
            // Console.WriteLine($"{Name} may add one charge to and activate a single rune");
        }

        public bool IsSpellReadyToCast()
        {
            // TODO rune system
            return false;
        }

        public void AddToCauldron(ElementalStrength strength)
        {
            this.cauldron.AddStrengths(strength);
        }

        public bool AddCatalyst(CatalystType type)
        {
            if (catalyst != CatalystType.None)
            {
                Console.WriteLine($"{Name} already has a catalyst");
                return false;
            }

            Console.WriteLine($"Adding {type.ToString()} catalyst to {Name}'s cauldron");
            catalyst = type;
            return true;
        }
    }
}
