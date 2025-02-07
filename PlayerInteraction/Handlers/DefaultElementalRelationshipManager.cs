using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Default elemental relationships. Natural>Mechanical>Unnatural>Natural.....
     * Default elemental attack order. Strong->Weak->Neutral
     */
    public class DefaultElementalRelationshipManager : IElementalRelationshipManager
    {
        static List<Element> orderIfTargetNatural = new List<Element>() { Element.Unnatural, Element.Mechanical, Element.Natural };
        static List<Element> orderIfTargetMechanical = new List<Element>() { Element.Natural, Element.Unnatural, Element.Mechanical };
        static List<Element> orderIfTargetUnnatural = new List<Element>() { Element.Mechanical, Element.Natural, Element.Unnatural };
        Dictionary<Element, List<Element>> orderByElement;

        public DefaultElementalRelationshipManager()
        {
            orderByElement = new Dictionary<Element, List<Element>>();
            orderByElement.Add(Element.Natural, orderIfTargetNatural);
            orderByElement.Add(Element.Mechanical, orderIfTargetMechanical);
            orderByElement.Add(Element.Unnatural, orderIfTargetUnnatural);
        }

        /// <summary>
        /// Returns List of Elements in the order that damage should be taken against the provided Element.
        /// Order is Strong Against -> Weak Against -> Neutral
        /// </summary>
        public List<Element> GetElementalDamageOrder(Element target)
        {
            return orderByElement[target];
        }

        /// <summary>
        /// Returns Element strong against provided Element.
        /// </summary>
        public Element GetElementStrongAgainst(Element target)
        {
            return orderByElement[target][0];
        }

        /// <summary>
        /// Returns Element weak against provided Element.
        /// </summary>
        public Element GetElementWeakAgainst(Element target)
        {
            return orderByElement[target][1];
        }
    }
}
