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

        private bool hasBeenActivated;

        public Rune()
        {
            hasBeenActivated = false;
            currentDelayCounters = -1;
            currentCharges = 0;
        }

        public bool ChargeRune()
        {
            if (currentCharges == MaxCharges)
            {
                return false;
            }

            currentCharges++;
            return true;
        }

        public bool ActivateRune()
        {
            if (hasBeenActivated) return false;

            hasBeenActivated = true;
            currentDelayCounters = MaxDelayCounters;
            return true;
        }

        public bool DecrementDelayAndCheckIfZero()
        {
            currentDelayCounters--;
            if (currentDelayCounters == 0)
            {
                hasBeenActivated = false;
                return true;
            }
            return false;
        }
    }
}
