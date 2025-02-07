using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Calculates final damage and remaining ward after factoring in targeted Player's current ward.
     * Created 1/13/25
     */
    public interface IWardHandler
    {
        /// <summary>
        /// Returns adjusted Ward and any excess damage per provided ward and provided incoming damage.
        /// </summary>
        WardAndDamageWrapper GetAdjustedWardAndFinalDamageAmount(ElementalStrength ward, Element damageElement, int damageTotal);
    }

    /*
     * Wrapper class for storing adjusted Ward and excess Damage after receiving incoming damage.
     */
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
