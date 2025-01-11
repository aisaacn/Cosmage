using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    public interface IDamageHandler
    {
        int CalculateAdjustedDamage(Element targetElement, int damage, Element damageElement);
    }
}
