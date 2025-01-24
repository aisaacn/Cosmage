using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Passive Item that gives the Player +1 Ward for each Element at the start of the game.
     * Created 1/21/25
     */
    public class AllWardTome : PassiveItem
    {
        public override string Name { get; protected set; }
        public override int SatchelWeight { get; protected set; }
        public override bool TargetsOtherPlayer { get; protected set; }

        public AllWardTome()
        {
            Name = "All Ward Tome";
            SatchelWeight = 20;
            TargetsOtherPlayer = false;
        }

        public override void HandlePassiveEffect(Player player)
        {
            if (!player.WardPrevented)
                player.AddWard(new ElementalStrength(1, 1, 1));
        }
    }
}
