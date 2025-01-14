using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    public class Construct
    {
        public ElementalStrength Strength { get; private set; }
        public bool HasSummoningSickness { get; private set; }

        public Construct(ElementalStrength strength)
        {
            Strength = strength;
            HasSummoningSickness = true;
        }

        public void DecrementAllStrengths()
        {
            if (HasSummoningSickness)
            {
                HasSummoningSickness = false;
                return;
            }

            Strength.RemoveStrength(Element.Natural, 1);
            Strength.RemoveStrength(Element.Mechanical, 1);
            Strength.RemoveStrength(Element.Unnatural, 1);
        }

        public bool IsDestroyed()
        {
            return Strength.GetMagnitude() <= 0;
        }
    }
}
