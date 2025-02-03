using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    public abstract class Targetable
    {
        public abstract Element Element { get; protected set; }

        public abstract int ReceiveDamage(Element element, int damageAmount);
    }
}
