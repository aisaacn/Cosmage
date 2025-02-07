using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Abstract type for Player Runes. Facilitates casting spells.
     * Runes can have multiple charges that yield different effects when used to cast a spell (+1 strength, for example). Needs at least one charge to execute.
     * Runes have different casting speeds based on delay counters; when activated, add max delay counters and decrement each turn. When delay reaches zero, execute spell.
     * Created 1/7/25
     */
    public abstract class Rune
    {
        public abstract string Name { get; protected set; }
        protected abstract int MaxDelayCounters { get; set; }
        private int currentDelayCounters;

        protected abstract int MaxCharges { get; set; }
        public int CurrentCharges { get; protected set; }

        protected abstract List<int> EffectByCharge { get; set; }

        public bool IsActive {  get; private set; }

        public Rune()
        {
            Initialize();
        }

        /// <summary>
        /// Sets Rune to initial state.
        /// </summary>
        private void Initialize()
        {
            IsActive = false;
            currentDelayCounters = -1;
            CurrentCharges = 0;
        }
        
        /// <summary>
        /// Adds 1 Charge to Rune. Returns false if Rune is at max charge.
        /// </summary>
        public bool ChargeRune()
        {
            if (IsMaxCharge())
            {
                return false;
            }

            CurrentCharges++;
            return true;
        }

        /// <summary>
        /// Returns true if Rune is at max charge.
        /// </summary>
        public bool IsMaxCharge()
        {
            return CurrentCharges == MaxCharges;
        }

        /// <summary>
        /// Activates Rune, giving it max Delay counters. Returns false if Rune is already Active.
        /// </summary>
        public bool ActivateRune()
        {
            if (IsActive) return false;

            IsActive = true;
            currentDelayCounters = MaxDelayCounters;
            return true;
        }

        /// <summary>
        /// Decrease Delay counters by 1 if Rune is active. If Delay reaches 0, return Rune effect.
        /// </summary>
        public int DecrementDelayAndReturnEffectIfDelayBecomesZero()
        {
            int effect = int.MinValue;
            if (!IsActive) return effect;

            currentDelayCounters--;
            if (currentDelayCounters == 0)
            {
                if (CurrentCharges == 0)
                {
                    // Rune cannot cast spell without at least 1 charge
                    Initialize();
                    return effect;
                }
                effect = GetEffectByCharge();
                Initialize();
                return effect;
            }
            return effect;
        }

        /// <summary>
        /// Adds or removes Delay counters. Delay cannot be reduced below 1 this way.
        /// </summary>
        public void ModifyDelay(int delta)
        {
            // TODO only if Rune is active.
            currentDelayCounters += delta;
            if (currentDelayCounters == 0)
                currentDelayCounters++;
        }

        /// <summary>
        /// Returns Rune effect by charge level. 
        /// </summary>
        public int GetEffectByCharge()
        {
            // TODO evaluate potential bug with charge effects
            return EffectByCharge[CurrentCharges - 1];
        }

        /// <summary>
        /// Returns formatted string of Rune status (charges and delay counters).
        /// </summary>
        public String StatusToString()
        {
            return $"Charges: {CurrentCharges} Delay: {currentDelayCounters}";
        }
    }
}
