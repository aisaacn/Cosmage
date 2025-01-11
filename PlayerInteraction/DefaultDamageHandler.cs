using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CosmageV2.PlayerInteraction
{
    public class DefaultDamageHandler : IDamageHandler
    {
        IElementalRelationshipManager elementalRelationshipManager;

        public DefaultDamageHandler()
        {
            elementalRelationshipManager = new DefaultElementalRelationshipManager();
        }

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
