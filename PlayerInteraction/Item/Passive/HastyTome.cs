using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Passive Item that increases the Player's Haste by 1. Players with more Haste go first.
     * Created 1/21/25
     */
    public class HastyTome : PassiveItem
    {
        public override string Name { get; protected set; }
        public override int SatchelWeight { get; protected set; }
        public override bool TargetsOtherPlayer { get; protected set; }
        public override string Tooltip { get; protected set; }

        public HastyTome()
        {
            Name = "Hasty Tome";
            SatchelWeight = 15;
            TargetsOtherPlayer = false;
            Tooltip = "Passive Item that increases the Player's Haste by 1. Players with more Haste go first.";
        }

        public override void HandlePassiveEffect(Player player)
        {
            player.Haste++;
        }
    }
}
