using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Single-use Items that are not added to the Cauldron, but have various effects on the battle or current spell.
     * Created 1/15/25
     */
    public abstract class Consumable : Item
    {
        public abstract void UseConsumable();
        public abstract void UseConsumableWithWormhole();
    }
}
