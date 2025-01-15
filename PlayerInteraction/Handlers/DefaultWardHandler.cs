using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Default behavior for Ward interactions.
     * Created 1/14/25
     */
    public class DefaultWardHandler : IWardHandler
    {
        IElementalRelationshipManager elementalRelationshipManager;

        public DefaultWardHandler(IElementalRelationshipManager erm)
        {
            elementalRelationshipManager = erm;
        }

        public WardAndDamageWrapper GetAdjustedWardAndFinalDamageAmount(ElementalStrength ward, Element damageElement, int damageTotal)
        {
            int tempDamage = damageTotal;
            ElementalStrength tempWard = ward;
            int tempWardAmount = 0;

            // TODO simplify cases / make more elegant
            foreach (Element e in elementalRelationshipManager.GetElementalDamageOrder(damageElement))
            {
                tempWardAmount = tempWard.GetStrength(e);
                if (tempWardAmount > 0)
                {
                    tempWard.RemoveStrength(e, tempDamage);
                    if (tempWardAmount < tempDamage)
                    {
                        tempDamage -= tempWardAmount;
                    }
                    else // If damage is fully blocked by ward, no need to continue
                    {
                        tempDamage = 0;
                        break;
                    }

                    // If ward is strong or neutral against incoming damage element, block overflow damage
                    if (!e.Equals(elementalRelationshipManager.GetElementWeakAgainst(damageElement)))
                    {
                        tempDamage = 0;
                        break;
                    }
                }
            }
            return new WardAndDamageWrapper(tempWard, tempDamage);
        }
    }
}
