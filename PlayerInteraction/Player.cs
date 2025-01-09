using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmageV2.PlayerInteraction
{
    public class Player
    {
        public Element Element { get; }
        public string Name { get; }
        public int Health { get; private set; }
        public List<Construct> Constructs { get; private set; }
        public ElementalStrength Cauldron {  get; private set; }
        public CatalystType Catalyst { get; private set; }
        public List<Rune> Runes { get; private set; }

        IAddIngredientHandler addIngredientHandler;
        IGameBoardUpdater gameBoardUpdater;
        IRunePhaseHandler runePhaseHandler;

        public Player(Element element, string name) 
        {
            Element = element;
            Name = name;
            Health = 20; //TODO: abstract health for different rulesets

            Constructs = new List<Construct>();
            Cauldron = new ElementalStrength();
            Catalyst = CatalystType.None;
            CreateRunes();

            // TODO add ruleset manager to create all appropriate handlers
            addIngredientHandler = new WinFormAddIngredientHandler();
            gameBoardUpdater = new WinFormGameBoardUpdater();
            runePhaseHandler = new WinFormRunePhaseHandler();
        }

        public void HandleAddIngredient()
        {
            addIngredientHandler.HandleAddIngredient(this);
            gameBoardUpdater.UpdateLabels(this);
        }

        public void HandleUseConsumables()
        {
            // TODO implement user interaction (consumables will simply modify cauldron for now)
            // Console.WriteLine($"{Name} may use any number of consumables");
        }

        public void HandleRunePhase()
        {
            runePhaseHandler.HandleRunePhase(this);
            gameBoardUpdater.UpdateLabels(this);
        }

        public bool IsSpellReadyToCast()
        {
            // TODO rune system
            return false;
        }

        public void AddToCauldron(ElementalStrength strength)
        {
            Cauldron.AddStrengths(strength);
        }

        public bool AddCatalyst(CatalystType type)
        {
            if (Catalyst != CatalystType.None)
            {
                Console.WriteLine($"{Name} already has a catalyst");
                return false;
            }

            //Console.WriteLine($"Adding {type.ToString()} catalyst to {Name}'s cauldron");
            Catalyst = type;
            return true;
        }

        public bool ChargeRune(int runeIndex)
        {
            return Runes[runeIndex].ChargeRune();
        }

        public bool IsRuneMaxCharge(int runeIndex)
        {
            return Runes[runeIndex].IsMaxCharge();
        }

        public bool ActivateRune(int runeIndex)
        {
            return Runes[runeIndex].ActivateRune();
        }

        public bool IsRuneActive(int runeIndex)
        {
            return Runes[runeIndex].IsActive;
        }

        public String RuneNamesToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Rune rune in Runes)
            {
                sb.Append(rune.Name + ":\r\n");
            }
            return sb.ToString();
        }

        public String RuneStatusToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Rune rune in Runes)
            {
                sb.Append(rune.StatusToString() + "\r\n");
            }
            return sb.ToString();
        }

        private void CreateRunes()
        {
            // TODO use runes from player loadout
            Runes = new List<Rune> { new InstantRune(), new StandardRune(), new DelayedRune() };
        }
    }
}
