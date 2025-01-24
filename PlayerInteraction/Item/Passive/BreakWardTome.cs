using CosmageV2.PlayerInteraction.Itemization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Passive Item that prevents opposing Player from gaining Ward from Passive Items.
     * Created 1/21/25
     */
    public class BreakWardTome : PassiveItem
    {
        public override string Name { get; protected set; }
        public override int SatchelWeight { get; protected set; }
        public override bool TargetsOtherPlayer { get; protected set; }

        public BreakWardTome()
        {
            Name = "Break Ward Tome";
            SatchelWeight = 25;
            TargetsOtherPlayer = true;
        }

        public override void HandlePassiveEffect(Player player)
        {
            player.WardPrevented = true;
            player.Ward.SetZero();
        }
    }
}
