using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    public abstract class Rune
    {
        public abstract string Name { get; protected set; }
        protected abstract int MaxDelayCounters { get; set; }
        private int currentDelayCounters;

        protected abstract int MaxCharges { get; set; }
        private int currentCharges;

        protected abstract List<int> EffectByCharge { get; set; }

        public bool IsActive {  get; private set; }

        public Rune()
        {
            Initialize();
        }

        private void Initialize()
        {
            IsActive = false;
            currentDelayCounters = -1;
            currentCharges = 0;
        }

        public bool ChargeRune()
        {
            if (IsMaxCharge())
            {
                return false;
            }

            currentCharges++;
            return true;
        }

        public bool IsMaxCharge()
        {
            return currentCharges == MaxCharges;
        }

        public bool ActivateRune()
        {
            if (IsActive) return false;

            IsActive = true;
            currentDelayCounters = MaxDelayCounters;
            return true;
        }

        public int DecrementDelayAndReturnEffectIfDelayBecomesZero()
        {
            int effect = int.MinValue;
            if (!IsActive) return effect;

            currentDelayCounters--;
            if (currentDelayCounters == 0)
            {
                if (currentCharges == 0)
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

        public int GetEffectByCharge()
        {
            return EffectByCharge[currentCharges - 1];
        }

        public String StatusToString()
        {
            return $"Charges: {currentCharges} Delay: {currentDelayCounters}";
        }
    }
}
