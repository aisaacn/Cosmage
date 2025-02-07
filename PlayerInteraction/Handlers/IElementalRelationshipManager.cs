using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Contains elemental strength/weakness relationships and damage order for multi-elemental interactions.
     * Created 1/7/25
     */
    public interface IElementalRelationshipManager
    {
        /// <summary>
        /// Returns Element strong against provided Element.
        /// </summary>
        Element GetElementStrongAgainst(Element target);

        /// <summary>
        /// Returns Element weak against provided Element.
        /// </summary>
        Element GetElementWeakAgainst(Element target);

        /// <summary>
        /// Returns List of Elements in the order that damage should be applied to the provided Element.
        /// Default order is Strong Against -> Weak Against -> Neutral
        /// </summary>
        List<Element> GetElementalDamageOrder(Element target);
    }
}
