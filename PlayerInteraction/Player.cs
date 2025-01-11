using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CosmageV2.PlayerInteraction
{
    public class Player
    {
        public Element Element { get; }
        public string Name { get; }
        public int Health { get; private set; }
        public ElementalStrength Ward { get; private set; }
        public List<Construct> Constructs { get; private set; }
        public ElementalStrength Cauldron {  get; private set; }
        public CatalystType Catalyst { get; private set; }
        public List<Rune> Runes { get; private set; }

        IAddIngredientHandler addIngredientHandler;
        IRunePhaseHandler runePhaseHandler;
        IElementalRelationshipManager elementalRelationshipManager;

        public Player(Element element, string name) 
        {
            Element = element;
            Name = name;
            Health = 20; //TODO: abstract health for different rulesets

            Ward = new ElementalStrength();
            Constructs = new List<Construct>();
            Cauldron = new ElementalStrength();
            Catalyst = CatalystType.None;
            CreateRunes();

            // TODO add ruleset manager to create all appropriate handlers
            addIngredientHandler = new WinFormAddIngredientHandler();
            runePhaseHandler = new WinFormRunePhaseHandler();
            elementalRelationshipManager = new DefaultElementalRelationshipManager();
        }

        public void HandleAddIngredient()
        {
            addIngredientHandler.HandleAddIngredient(this);
        }

        public void HandleUseConsumables()
        {
            // TODO implement user interaction (consumables will simply modify cauldron for now)
            // Console.WriteLine($"{Name} may use any number of consumables");
        }

        public void HandleRunePhase()
        {
            runePhaseHandler.HandleRunePhase(this);
        }

        public Spell HandleExecutionPhaseAndGetPreparedSpell()
        {
            int runeEffect = DecrementRuneDelayAndGetEffectIncrease();
            if (runeEffect == int.MinValue)
            {
                return null;
            }
            return PrepareSpell(runeEffect);
        }

        private Spell PrepareSpell(int runeEffect)
        {
            // Don't cast spell if no essence, no catalyst, or if runeEffect reduces spell strength to less than 1
            if (Cauldron.GetMagnitude() == 0
                || Catalyst.Equals(CatalystType.None)
                || Cauldron.GetMagnitude() <= -runeEffect) 
                return null;
            
            if (runeEffect < 0)
            {
                // Removes strength from strongest element, or from Player's element if tied
                // TODO consider which element should be removed from tie between both non-player elements
                Cauldron.AddStrength(Cauldron.GetPrimaryElementWithTiebreakerPreference(Element), runeEffect);
            }
            else
            {
                Cauldron.AddStrength(Element, runeEffect);
            }

            Spell spell = new Spell(Cauldron, Catalyst);

            Cauldron = new ElementalStrength();
            Catalyst = CatalystType.None;

            return spell;
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

        public void AddWard(ElementalStrength strength)
        {
            Ward.AddStrengths(strength);
        }

        public void AddConstruct(ElementalStrength strength)
        {
            Constructs.Add(new Construct(strength));
        }

        public string ConstructsToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Construct construct in Constructs)
            {
                sb.Append(construct.Strength.ToString());
                sb.Append("\r\n");
            }
            return sb.ToString();
        }

        public void ReceiveDamage(Element element, int damage)
        {
            // TODO consider calculating adjusted damage in ElementalRelationshipManager (or something like IDamageHandler)
            int adjDamage = damage;
            if (element.Equals(elementalRelationshipManager.GetElementStrongAgainst(Element)))
                adjDamage++;

            if (element.Equals(elementalRelationshipManager.GetElementWeakAgainst(Element)))
                adjDamage--;

            // TODO factor in ward

            LoseHealth(adjDamage);
        }

        private void LoseHealth(int damage)
        {
            Health -= damage;
        }

        private void CreateRunes()
        {
            // TODO use runes from player loadout
            Runes = new List<Rune> { new InstantRune(), new StandardRune(), new DelayedRune() };
        }

        private int DecrementRuneDelayAndGetEffectIncrease()
        {
            int effect = int.MinValue;
            foreach (Rune rune in Runes)
            {
                effect = Math.Max(effect, rune.DecrementDelayAndReturnEffectIfDelayBecomesZero());
            }
            return effect;
        }
    }
}
