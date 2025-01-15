﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Item
{
    /*
     * Items that are added to the Cauldron to directly modify the current spell. Includes Catalysts and Essences.
     * Created 1/15/25
     */
    public abstract class Ingredient : Item
    {
        public abstract void AddToCauldron();
    }
}