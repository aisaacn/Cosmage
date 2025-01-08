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
        public void HandleRunePhase(Player player)
        {
            RunePhaseGui gui = new RunePhaseGui();
            // gui.ShowDialog();

            if (gui.ActivateRune)
            {
                TryActivatingAndChargingRune(player);
            }
            else
            {
                TryChargingRune(player);
            }
        }

        private void TryChargingRune(Player player)
        {
            // TODO
        }

        private void TryActivatingAndChargingRune(Player player)
        {
            // TODO
        }
    }
}
