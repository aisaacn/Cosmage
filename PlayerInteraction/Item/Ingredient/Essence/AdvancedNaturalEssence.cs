﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Adds 2 Natural strength to Cauldron.
     * Created 1/15/25
     */
    public class AdvancedNaturalEssence : Essence
    {
        public override string Name { get; protected set; }
        public override int SatchelWeight { get; protected set; }
        public override Element Element { get; protected set; }
        public override int Magnitude { get; protected set; }
        public override string Tooltip { get; protected set; }

        public AdvancedNaturalEssence()
        {
            Name = "Advanced Natural Essence";
            SatchelWeight = 10;
            Element = Element.Natural;
            Magnitude = 2;
            Tooltip = "Adds 2 Natural strength to Cauldron";
        }
    }
}
