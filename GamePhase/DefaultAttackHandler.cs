using CosmageV2.PlayerInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    public class DefaultAttackHandler : IAttackHandler
    {
        // Damage is dealt in order of strong, weak, then neutral against target player
        // TODO consider more elegant ways to achieve this order
        static List<Element> orderIfTargetNatural = new List<Element>() { Element.Unnatural, Element.Mechanical, Element.Natural };
        static List<Element> orderIfTargetMechanical = new List<Element>() { Element.Natural, Element.Unnatural, Element.Mechanical };
        static List<Element> orderIfTargetUnnatural = new List<Element>() { Element.Mechanical, Element.Natural, Element.Unnatural };
        Dictionary<Element, List<Element>> attackOrderByElement;

        public DefaultAttackHandler()
        {
            attackOrderByElement = new Dictionary<Element, List<Element>>();
            attackOrderByElement.Add(Element.Natural, orderIfTargetNatural);
            attackOrderByElement.Add(Element.Mechanical, orderIfTargetMechanical);
            attackOrderByElement.Add(Element.Unnatural, orderIfTargetUnnatural);
        }

        public void HandleAttack(ElementalStrength strength, Player target)
        {
            //Console.WriteLine($"{target.Name} has been attacked! {strength.ToString()}");
            foreach (Element element in attackOrderByElement[target.Element])
            {
                if (strength.GetStrength(element) > 0)
                    target.ReceiveDamage(element, strength.GetStrength(element));
            }
        }
    }
}
