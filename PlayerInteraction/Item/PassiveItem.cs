using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Items that are not used or added to the Cauldron, but passively affect the player or battlefield (typically at the start of a game)
     * Created 1/15/25
     */
    public abstract class PassiveItem : Item
    {
        public abstract void HandlePassiveEffect();
    }
}
