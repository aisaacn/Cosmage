using CosmageV2.GamePhase;
using CosmageV2.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Uses rudimentary WinForm GUI to accept user input when handling Rune charging and activation.
     * Created 1/5/25
     */
    public class WinFormRunePhaseHandler : IRunePhaseHandler
    {
        int runeChargeIndex;
        int runeActivateIndex;

        public void HandleRunePhase(Player player)
        {
            RunePhaseGui gui = new RunePhaseGui();
            gui.ShowDialog();
            runeChargeIndex = gui.RuneChargeIndex;
            runeActivateIndex = gui.RuneActivateIndex;

            if (runeChargeIndex < 0)
            {
                HandleRunePhase(player);
                return;
            }

            if (runeActivateIndex == -1)
            {
                TryChargingRune(player);
            }
            else
            {
                TryChargingAndActivatingRune(player);
            }
        }

        private bool TryChargingRune(Player player)
        {
            if (player.IsRuneMaxCharge(runeChargeIndex))
            {
                //Console.WriteLine("Rune is already max charge");
                HandleRunePhase(player);
                return false;
            }

            GamePhaseManager.Instance.LogEvent($"{player.Name} has charged their {player.Runes[runeChargeIndex].Name}");
            player.ChargeRune(runeChargeIndex);
            return true;
        }

        private bool TryChargingAndActivatingRune(Player player)
        {
            if (player.IsRuneActive(runeActivateIndex))
            {
                //Console.WriteLine("Rune is already activated");
                HandleRunePhase(player);
                return false;
            }

            if (!TryChargingRune(player))
            {
                return false;
            }

            GamePhaseManager.Instance.LogEvent($"{player.Name} has activated their {player.Runes[runeActivateIndex].Name}");
            player.ActivateRune(runeActivateIndex);
            return true;
        }
    }
}
