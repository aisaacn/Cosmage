using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
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

        public List<Element> GetElementalDamageOrder(Element target)
        {
            return orderByElement[target];
        }

        public Element GetElementStrongAgainst(Element target)
        {
            return orderByElement[target][0];
        }

        public Element GetElementWeakAgainst(Element target)
        {
            return orderByElement[target][1];
        }
    }
}
