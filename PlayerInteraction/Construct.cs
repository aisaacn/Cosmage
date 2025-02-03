using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Tracks properties and handles decay of Player Constructs.
     * Created 1/5/25
     */
    public class Construct : Targetable
    {
        public override Element Element { get; protected set; }
        public ElementalStrength Strength { get; private set; }
        public bool HasSummoningSickness { get; private set; }

        private IWardHandler wardHandler;

        public Construct(ElementalStrength strength, Element playerElement, IWardHandler playerWardHandler)
        {
            Strength = strength;
            HasSummoningSickness = true;
            Element = Strength.GetPrimaryElementWithTiebreakerPreference(playerElement);
            wardHandler = playerWardHandler;
        }

        public override int ReceiveDamage(Element element, int damageAmount)
        {
            WardAndDamageWrapper result = wardHandler.GetAdjustedWardAndFinalDamageAmount(Strength, element, damageAmount);
            Strength = result.Ward;
            return result.Damage;
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
