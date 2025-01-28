using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Passive Item that gives the Player +1 Natural Ward at the start of the game.
     * Created 1/21/25
     */
    public class NaturalWardTome : PassiveItem
    {
        public override string Name { get; protected set; }
        public override int SatchelWeight { get; protected set; }
        public override bool TargetsOtherPlayer { get; protected set; }
        public override string Tooltip { get; protected set; }

        public NaturalWardTome()
        {
            Name = "Natural Ward Tome";
            SatchelWeight = 20;
            TargetsOtherPlayer = false;
            Tooltip = "Passive Item that gives the Player +1 Natural Ward at the start of the game.";
        }

        public override void HandlePassiveEffect(Player player)
        {
            if (!player.WardPrevented)
                player.AddWard(new ElementalStrength(1, 0, 0));
        }
    }
}
