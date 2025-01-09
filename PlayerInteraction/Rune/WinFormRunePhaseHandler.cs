using CosmageV2.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    internal class WinFormRunePhaseHandler : IRunePhaseHandler
    {
        private int runeIndex;

        public void HandleRunePhase(Player player)
        {
            RunePhaseGui gui = new RunePhaseGui();
            gui.ShowDialog();
            runeIndex = gui.ChargedRuneIndex;

            if (gui.ActivateRune)
            {
                if (!TryActivatingAndChargingRune(player)) HandleRunePhase(player);
            }
            else
            {
                if (!TryChargingRune(player)) HandleRunePhase(player);
            }
        }

        private bool TryChargingRune(Player player)
        {
            if (player.IsRuneMaxCharge(runeIndex))
            {
                Console.WriteLine("Rune already max charge");
                return false;
            }

            player.ChargeRune(runeIndex);
            return true;
        }

        private bool TryActivatingAndChargingRune(Player player)
        {
            if (player.IsRuneActive(runeIndex))
            {
                Console.WriteLine("Rune already activated");
                return false;
            }

            if (!TryChargingRune(player)) return false;
            
            player.ActivateRune(runeIndex);
            return true;
        }
    }
}
