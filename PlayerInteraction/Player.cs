using CosmageV2.GamePhase;
using CosmageV2.GUI;
using CosmageV2.PlayerInteraction.Itemization;
using System;
using System.Collections.Generic;
using System.Text;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Handles Player info and functionality. Tracks Health, Ward, Constructs, Runes, and Cauldron status.
     * Facilitates casting spells, creating Construct, charging Runes, and calculating damage based on Ward and Element.
     * Created 1/1/25
     */
    public class Player : Targetable
    {
        public override Element Element { get; protected set; }
        public override string Name { get => _name; }
        private string _name;
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

        IGuiManager guiManager;
        IAddIngredientHandler addIngredientHandler;
        IRunePhaseHandler runePhaseHandler;
        IConsumablePhaseHandler consumablePhaseHandler;
        IChooseAttackTargetHandler chooseAttackTargetHandler;

        IRulesetManager rulesetManager;
        IDamageHandler damageHandler;
        IWardHandler wardHandler;

        public Player(Element element, string name) 
        {
            InitializePlayer(element, name);
        }

        public Player(Element element, string name, IRulesetManager ruleset, IGuiManager gui)
        {
            rulesetManager = ruleset;
            guiManager = gui;
            InitializePlayer(element, name);
        }

        /// <summary>
        /// Sets Player data to initial state.
        /// </summary>
        public void InitializePlayer(Element element, string name)
        {
            Element = element;
            _name = name;

            Haste = 0;
            Prepared = false;
            WardPrevented = false;

            Ward = new ElementalStrength();
            Constructs = new List<Construct>();
            Cauldron = new ElementalStrength();
            Catalyst = CatalystType.None;
            CreateRunes();

            ConfigureRuleset();
            ConfigureGui();
        }

        /// <summary>
        /// Configres logic handlers per provided IRulesetManager. If none provided, uses the one from GamePhaseManager.
        /// </summary>
        private void ConfigureRuleset()
        {
            if (rulesetManager is null)
            {
                if (GamePhaseManager.Instance.RulesetManager is null)
                    throw new Exception("RulesetManager must be set in GamePhaseManager.");
                rulesetManager = GamePhaseManager.Instance.RulesetManager;
            }

            Health = rulesetManager.PlayerMaxHealth;
            damageHandler = rulesetManager.DamageHandler;
            wardHandler = rulesetManager.WardHandler;
        }

        /// <summary>
        /// Configres GUI handlers per provided IGuiManager. If none provided, uses the one from GamePhaseManager.
        /// </summary>
        private void ConfigureGui()
        {
            if (guiManager is null)
            {
                if (GamePhaseManager.Instance.GuiManager is null)
                    throw new Exception("GuiManager must be set in GamePhaseManager.");
                guiManager = GamePhaseManager.Instance.GuiManager;
            }

            addIngredientHandler = guiManager.AddIngredientHandler;
            runePhaseHandler = guiManager.RunePhaseHandler;
            consumablePhaseHandler = guiManager.ConsumablePhaseHandler;
            chooseAttackTargetHandler = guiManager.ChooseAttackTargetHandler;
        }

        /// <summary>
        /// Configure Player's Satchel of items.
        /// </summary>
        public void SetSatchel(Satchel newSatchel)
        {
            // TODO satchel size check. If newSatchel.Size <= rulesManager.MaxSatchelSize
            Satchel = newSatchel;
        }

        /// <summary>
        /// Executes Player's Ingredient Phase per provided IAddIngredientHandler.
        /// </summary>
        public void HandleAddIngredient()
        {
            addIngredientHandler.HandleAddIngredient(this);
        }

        /// <summary>
        /// Executes Player's Consumable Phase per provided IConsumablePhaseHandler.
        /// </summary>
        public void HandleUseConsumables()
        {
            consumablePhaseHandler.HandleConsumablePhase(this);
        }

        /// <summary>
        /// Executes Player's Rune Phase per provided IRunePhaseHandler.
        /// </summary>
        public void HandleRunePhase()
        {
            runePhaseHandler.HandleRunePhase(this);
        }

        /// <summary>
        /// Executes Player's Execution Phase by decrementing all activated Runes' Delay counters. If Delay reaches 0, returns a Spell to be cast.
        /// </summary>
        public Spell HandleExecutionPhaseAndGetPreparedSpell()
        {
            int runeEffect = DecrementRuneDelayAndGetEffectIncrease();
            if (runeEffect == int.MinValue)
            {
                return null;
            }
            return PrepareSpell(runeEffect);
        }

        /// <summary>
        /// Decrements each of Player's Constructs strength by 1 for each element. Removes Constructs with 0 strength.
        /// </summary>
        public void DecrementAllConstructs()
        {
            foreach (Construct c in Constructs)
            {
                c.DecrementAllStrengths();
            }
            RemoveDetroyedConstructs();
        }

        /// <summary>
        /// Removes all of Player's Constructs with 0 strength.
        /// </summary>
        public void RemoveDetroyedConstructs()
        {
            List<Construct> toDestroy = new List<Construct>();
            foreach (Construct c in Constructs)
            {
                if (c.IsDestroyed()) toDestroy.Add(c);
            }

            foreach (Construct c in toDestroy)
            {
                Constructs.Remove(c);
            }
        }

        /// <summary>
        /// Creates Spell to be executed if all criteria are met. Returns Cauldron to base state upon successful Spell creation.
        /// </summary>
        private Spell PrepareSpell(int runeEffect)
        {
            // Don't cast spell if no essence, no catalyst, or if runeEffect reduces spell strength to less than 1
            if (Cauldron.GetMagnitude() <= -runeEffect
                || Catalyst.Equals(CatalystType.None))
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
        
        /// <summary>
        /// Adds Essence Ingredient to Cauldron and removes from Satchel.
        /// </summary>
        public void AddEssenceAndRemoveFromSatchel(Essence essence)
        {
            LastEssence = essence;
            Cauldron.AddStrength(essence.Element, essence.Magnitude);
            Satchel.RemoveItem(essence);
        }

        /// <summary>
        /// Add Catalyst Ingredient to Cauldron and removes from Satchel. Fails if Cauldron already contains a Catalyst.
        /// </summary>
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

        /// <summary>
        /// Removes Consumable from Satchel. Only called upon Consumable use.
        /// </summary>
        public bool RemoveConsumableFromSatchel(Consumable consumable)
        {
            return Satchel.RemoveItem(consumable);
        }

        /// <summary>
        /// Add 1 Charge to the specified Rune. Returns false if Rune is at max charge.
        /// </summary>
        public bool ChargeRune(int runeIndex)
        {
            return Runes[runeIndex].ChargeRune();
        }

        /// <summary>
        /// Returns true if specified Rune is already at max Charges.
        /// </summary>
        public bool IsRuneMaxCharge(int runeIndex)
        {
            return Runes[runeIndex].IsMaxCharge();
        }

        /// <summary>
        /// Activates specified Rune. Returns false if Rune is already activated.
        /// </summary>
        public bool ActivateRune(int runeIndex)
        {
            LastActivatedRune = Runes[runeIndex];
            return Runes[runeIndex].ActivateRune();
        }

        /// <summary>
        /// Returns true if Rune is already activated.
        /// </summary>
        public bool IsRuneActive(int runeIndex)
        {
            return Runes[runeIndex].IsActive;
        }

        /// <summary>
        /// Returns formatted string of Player's Runes' names.
        /// </summary>
        public string RuneNamesToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Rune rune in Runes)
            {
                sb.Append(rune.Name + ":\r\n");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Returns formatted string of Player's Runes' statuses (charge level and activation).
        /// </summary>
        public string RuneStatusToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Rune rune in Runes)
            {
                sb.Append(rune.StatusToString() + "\r\n");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Adds provided Ward to Player's total Ward.
        /// </summary>
        public void AddWard(ElementalStrength strength)
        {
            Ward.AddStrengths(strength);
        }

        /// <summary>
        /// Adds new Construct to Player's list of Constructs.
        /// </summary>
        public void AddConstruct(ElementalStrength strength)
        {
            Constructs.Add(new Construct(strength, Element, wardHandler));
        }

        /// <summary>
        /// Returns formatted string of all Player's Constructs.
        /// </summary>
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

        /// <summary>
        /// Returns Target of Player's attack Spell. Defaults to opposing Player if that Player has no Constructs.
        /// </summary>
        public Targetable HandleChooseAttackTarget()
        {
            return chooseAttackTargetHandler.HandleChooseAttackTarget();
        }

        /// <summary>
        /// Adjusts incoming damage based on the relationship between the Elements of the Player and incoming damage.
        /// </summary>
        public override int ReceiveDamage(Element damageElement, int damageAmount)
        {
            int adjDamage = damageHandler.CalculateAdjustedDamage(Element, damageAmount, damageElement);
            return LoseHealthAfterFactoringWard(damageElement, adjDamage);
        }

        /// <summary>
        /// Adjusts Player's Health and Ward after incoming damage per IWardHandler.
        /// </summary>
        private int LoseHealthAfterFactoringWard(Element damageElement, int damage)
        {
            WardAndDamageWrapper damageResult = wardHandler.GetAdjustedWardAndFinalDamageAmount(Ward, damageElement, damage);
            Ward = damageResult.Ward;
            Health -= damageResult.Damage;
            return damageResult.Damage;
        }

        /// <summary>
        /// Creates Player's three Runes.
        /// </summary>
        private void CreateRunes()
        {
            // TODO use runes from player loadout
            Runes = new List<Rune> { new InstantRune(), new StandardRune(), new DelayedRune() };
        }

        /// <summary>
        /// Decrement each activated Rune's Delay counters by 1. Returns Rune's spell effect if Delay reaches 0.
        /// </summary>
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
