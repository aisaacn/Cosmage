using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Item
{
    /*
     * Items that are added to the Cauldron to increase the elemental strength of the current spell.
     * Created 1/15/25
     */
    public abstract class Essence : Ingredient
    {
        public abstract Element Element { get; protected set; }
        public abstract int Magnitude { get; protected set; }
    }
}
