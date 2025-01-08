using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    internal class StandardRune : Rune
    {
        public override string Name { get; protected set; }
        protected override int MaxDelayCounters { get; set; }
        protected override int MaxCharges { get; set; }
        protected override List<int> EffectByCharge { get; set; }

        public StandardRune() : base()
        {
            Name = "StandardRune";
            MaxDelayCounters = 2;
            MaxCharges = 3;
            EffectByCharge = new List<int>() { -1, 0, 1 };
        }
    }
}
