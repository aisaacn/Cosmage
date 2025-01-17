using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Spell will result in an Attack when this is added to the Cauldron.
     * Created 1/15/25
     */
    public class AttackCrystal : Catalyst
    {
        public override string Name { get; protected set; }
        public override int SatchelWeight { get; protected set; }
        public override CatalystType Type { get; protected set; }
        public override bool IsReusable { get; protected set; }

        public AttackCrystal()
        {
            Name = "Attack Crystal";
            SatchelWeight = 30;
            Type = CatalystType.Attack;
            IsReusable = true;
        }
    }
}
