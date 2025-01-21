using CosmageV2.PlayerInteraction.Itemization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Handles Player info and functionality. Tracks Health, Ward, Constructs, Runes, and Cauldron status.
     * Facilitates casting spells, creating Construct, charging Runes, and calculating damage based on Ward and Element.
     * Created 1/1/25
     */
    public class Player
    {
        public Element Element { get; }
        public string Name { get; }
        public int Health { get; set; }
        public ElementalStrength Ward { get; private set; }
        public List<Construct> Constructs { get; private set; }
        public ElementalStrength Cauldron { get; private set; }
        public CatalystType Catalyst { get; private set; }
        public List<Rune> Runes { get; private set; }
        public Satchel Satchel { get; private set; }

        public Essence LastEssence { get; private set; }
        public Rune LastActivatedRune { get; private set; }
        public int Haste {  get; set; }
        public bool Prepared { get; set; }
        public bool WardPrevented { get; set; }

        IAddIngredientHandler addIngredientHandler;
        IRunePhaseHandler runePhaseHandler;
        IConsumablePhaseHandler consumablePhaseHandler;

        IDamageHandler damageHandler;
        IWardHandler wardHandler;

        public Player(Element element, string name) 
        {
            Element = element;
            Name = name;
            Health = 20; //TODO: abstract health for different rulesets

            Haste = 0;
            Prepared = false;
            WardPrevented = false;

            Ward = new ElementalStrength();
            Constructs = new List<Construct>();
            Cauldron = new ElementalStrength();
            Catalyst = CatalystType.None;
            CreateRunes();

            // TODO add ruleset manager to create all appropriate handlers
            IElementalRelationshipManager relationshipManager = new DefaultElementalRelationshipManager();
            addIngredientHandler = new WinFormCustomSatchelAddIngredientHandler();
            runePhaseHandler = new WinFormRunePhaseHandler();
            consumablePhaseHandler = new WinFormConsumablePhaseHandler();

            damageHandler = new DefaultDamageHandler(relationshipManager);
            wardHandler = new DefaultWardHandler(relationshipManager);
        }

        public void SetSatchel(Satchel newSatchel)
        {
            // TODO satchel size check. If newSatchel.Size <= rulesManager.MaxSatchelSize
            Satchel = newSatchel;
        }

        public void HandleAddIngredient()
        {
            addIngredientHandler.HandleAddIngredient(this);
        }

        public void HandleUseConsumables()
        {
            consumablePhaseHandler.HandleConsumablePhase(this);
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

        public void DecrementAllConstructs()
        {
            List<Construct> toDestroy = new List<Construct>();
            foreach (Construct c in Constructs)
            {
                c.DecrementAllStrengths();
                if (c.IsDestroyed()) toDestroy.Add(c);
            }
            
            foreach (Construct c in toDestroy)
            {
                Constructs.Remove(c);
            }
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

        public void AddEssenceAndRemoveFromSatchel(Essence essence)
        {
            LastEssence = essence;
            Cauldron.AddStrength(essence.Element, essence.Magnitude);
            Satchel.RemoveItem(essence);
        }

        public bool AddCatalystAndRemoveFromSatchel(Catalyst catalyst)
        {
            if (Catalyst != CatalystType.None)
            {
                //Console.WriteLine($"{Name} already has a catalyst");
                return false;
            }

            //Console.WriteLine($"Adding {type.ToString()} catalyst to {Name}'s cauldron");
            Catalyst = catalyst.Type;
            if (!catalyst.IsReusable)
            {
                Satchel.RemoveItem(catalyst);
            }
            return true;
        }

        public bool RemoveConsumableFromSatchel(Consumable consumable)
        {
            return Satchel.RemoveItem(consumable);
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
            LastActivatedRune = Runes[runeIndex];
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

        public void ReceiveDamage(Element damageElement, int damageAmount)
        {
            int adjDamage = damageHandler.CalculateAdjustedDamage(Element, damageAmount, damageElement);
            LoseHealthAfterFactoringWard(damageElement, adjDamage);
        }

        private void LoseHealthAfterFactoringWard(Element damageElement, int damage)
        {
            WardAndDamageWrapper damageResult = wardHandler.GetAdjustedWardAndFinalDamageAmount(Ward, damageElement, damage);
            Ward = damageResult.Ward;
            Health -= damageResult.Damage;
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
