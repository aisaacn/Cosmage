using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    public interface IElementalRelationshipManager
    {
        Element GetElementStrongAgainst(Element target);

        Element GetElementWeakAgainst(Element target);

        List<Element> GetElementalDamageOrder(Element target);
    }
}
