using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Passive Item that allows the Player to have a full turn when going first (instead of skipping their first Rune Phase).
     * Created 1/21/25
     */
    public class PreparatoryTome : PassiveItem
    {
        public override string Name { get; protected set; }
        public override int SatchelWeight { get; protected set; }
        public override bool TargetsOtherPlayer { get; protected set; }

        public PreparatoryTome()
        {
            Name = "Preparatory Tome";
            SatchelWeight = 20;
            TargetsOtherPlayer = false;
        }

        public override void HandlePassiveEffect(Player player)
        {
            player.Prepared = true;
        }
    }
}
