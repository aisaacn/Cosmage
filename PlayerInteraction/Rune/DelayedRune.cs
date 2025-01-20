using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Rune type that executes two turns after it is activated.
     * Created 1/7/25
     */
    public class DelayedRune : Rune
    {
        public override string Name { get; protected set; }
        protected override int MaxDelayCounters { get; set; }
        protected override int MaxCharges { get; set; }
        protected override List<int> EffectByCharge { get; set; }

        public DelayedRune() : base()
        {
            Name = "DelayedRune";
            MaxDelayCounters = 3;
            MaxCharges = 3;
            EffectByCharge = new List<int>() { 0, 1, 2 };
        }
    }
}
