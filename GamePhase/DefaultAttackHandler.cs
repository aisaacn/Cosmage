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
        IElementalRelationshipManager elementalRelationshipManager;

        public DefaultAttackHandler()
        {
            elementalRelationshipManager = new DefaultElementalRelationshipManager();
        }

        public void HandleAttack(ElementalStrength strength, Player target)
        {
            //Console.WriteLine($"{target.Name} has been attacked! {strength.ToString()}");
            foreach (Element element in elementalRelationshipManager.GetElementalDamageOrder(target.Element))
            {
                if (strength.GetStrength(element) > 0)
                    target.ReceiveDamage(element, strength.GetStrength(element));
            }
        }
    }
}
