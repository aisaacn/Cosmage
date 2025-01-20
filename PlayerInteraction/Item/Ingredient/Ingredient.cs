using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Items that are added to the Cauldron to directly modify the current spell. Includes Catalysts and Essences.
     * Created 1/15/25
     */
    public abstract class Ingredient : Item
    {
        public bool HasBeenAddedToCauldron { get; private set; }

        public Ingredient()
        {
            HasBeenAddedToCauldron = false;
        }

        public void AddToCauldron()
        {
            HasBeenAddedToCauldron = true;
        }
    }
}
