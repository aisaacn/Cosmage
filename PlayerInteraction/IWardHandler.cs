using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    public interface IWardHandler
    {
        WardAndDamageWrapper GetAdjustedWardAndFinalDamageAmount(ElementalStrength ward, Element damageElement, int damageTotal);
    }

    public class WardAndDamageWrapper
    {
        // TODO where does this wrapper class belong?
        public ElementalStrength Ward { get; private set; }
        public int Damage { get; private set; }

        public WardAndDamageWrapper(ElementalStrength ward, int damage)
        {
            Ward = ward;
            Damage = damage;
        }
    }
}
