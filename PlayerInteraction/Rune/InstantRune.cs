using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    internal class InstantRune : Rune
    {
        public override string Name { get; protected set; }
        protected override int MaxDelayCounters { get; set; }
        protected override int MaxCharges { get; set; }
        protected override List<int> EffectByCharge { get; set; }

        public InstantRune() : base()
        {
            Name = "InstantRune";
            MaxDelayCounters = 1;
            MaxCharges = 2;
            EffectByCharge = new List<int>() { -1, 0 };
        }
    }
}
