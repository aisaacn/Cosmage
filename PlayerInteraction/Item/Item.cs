﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * General type for items that belong in a Player's satchel.
     * Includes Ingredients (Essences and Catalysts), Consumables, and Passives.
     * Created 1/15/25
     */
    public abstract class Item
    {
        public abstract string Name { get; protected set; }
        public abstract int SatchelWeight { get; protected set; }
        public abstract string Tooltip { get; protected set; }
    }
}
