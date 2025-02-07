using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Adjusts incoming damage based on elemental relationships.
     * Created 1/7/25
     */
    public interface IDamageHandler
    {
        /// <summary>
        /// Returns adjusted damage based on receiving Player's Element and incoming damage Element.
        /// Default behaviour is as follows:
        /// +1 Damage when incoming Element is strong against target's Element.
        /// -1 Damage when incoming Element is weak against target's Element.
        /// </summary>
        int CalculateAdjustedDamage(Element targetElement, int damage, Element damageElement);
    }
}
