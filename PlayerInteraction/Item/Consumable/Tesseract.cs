using CosmageV2.GamePhase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Consumable item that removes 1 Delay from last activated Rune. Cannot reduce Delay below 1.
     * Wormhole: Adds 1 Delay to opponent's last activated Rune.
     * Created 1/20/25
     */
    public class Tesseract : Consumable
    {
        public override string Name { get; protected set; }
        public override int SatchelWeight { get; protected set; }
        public override string Tooltip { get; protected set; }

        public Tesseract()
        {
            Name = "Tesseract";
            SatchelWeight = 35;
            Tooltip = "Consumable item that removes 1 Delay from last activated Rune. Cannot reduce Delay below 1\r\n\r\nWormhole: Adds 1 Delay to opponent's last activated Rune";
        }

        public override void UseConsumable()
        {
            Player currentPlayer = GamePhaseManager.Instance.CurrentPlayer;
            Rune lastRune = currentPlayer.LastActivatedRune;

            if (lastRune != null)
                lastRune.ModifyDelay(-1);
        }

        public override void UseConsumableWithWormhole()
        {
            Player targetPlayer = GamePhaseManager.Instance.InactivePlayer;
            Rune lastRune = targetPlayer.LastActivatedRune;

            if (lastRune != null)
                lastRune.ModifyDelay(1);
        }
    }
}
