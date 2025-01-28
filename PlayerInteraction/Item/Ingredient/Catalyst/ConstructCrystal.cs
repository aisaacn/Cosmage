using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Spell will result in a Construct when this is added to the Cauldron.
     * Created 1/15/25
     */
    public class ConstructCrystal : Catalyst
    {
        public override string Name { get; protected set; }
        public override int SatchelWeight { get; protected set; }
        public override CatalystType Type { get; protected set; }
        public override bool IsReusable { get; protected set; }
        public override string Tooltip { get; protected set; }

        public ConstructCrystal()
        {
            Name = "Construct Crystal";
            SatchelWeight = 25;
            Type = CatalystType.Construct;
            IsReusable = false;
            Tooltip = "Spell will result in a Construct when this is added to the Cauldron";
        }
    }
}
