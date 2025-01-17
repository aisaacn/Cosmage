using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Items that are added to the Cauldron to modify the functionality of the current spell.
     * Created 1/15/25
     */
    public abstract class Catalyst : Ingredient
    {
        public abstract CatalystType Type { get; protected set; }
        public abstract bool IsReusable { get; protected set; }
    }
}
