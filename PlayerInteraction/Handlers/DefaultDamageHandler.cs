using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Defines default elemental interactions: +1 when strong against target element, -1 when weak.
     */
    public class DefaultDamageHandler : IDamageHandler
    {
        // TODO combine with IElementalRelationshipManager or IWardHandler ?
        IElementalRelationshipManager elementalRelationshipManager;

        public DefaultDamageHandler(IElementalRelationshipManager erm)
        {
            elementalRelationshipManager = erm;
        }

        /// <summary>
        /// Returns adjusted damage based on receiving Player's Element and incoming damage Element.
        /// +1 Damage when incoming Element is strong against target's Element.
        /// -1 Damage when incoming Element is weak against target's Element.
        /// Elemental relationships are defined by provided IElementalRelationshipManager.
        /// </summary>
        public int CalculateAdjustedDamage(Element targetElement, int damage, Element damageElement)
        {
            int adjDamage = damage;
            if (damageElement.Equals(elementalRelationshipManager.GetElementStrongAgainst(targetElement)))
                adjDamage++;

            if (damageElement.Equals(elementalRelationshipManager.GetElementWeakAgainst(targetElement)))
                adjDamage--;

            return adjDamage;
        }
    }
}
