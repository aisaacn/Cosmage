using CosmageV2.PlayerInteraction;
using CosmageV2.PlayerInteraction.Itemization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    public class DefaultPassiveHandler : IPassiveHandler
    {
        public void HandlePassives(Player player1, Player player2)
        {
            HandleEachPassive(player1, player2);
            HandleEachPassive(player2, player1);
        }

        private void HandleEachPassive(Player currentPlayer, Player opposingPlayer)
        {
            foreach (PassiveItem passive in currentPlayer.Satchel.PassiveItems)
            {
                if (passive.TargetsOtherPlayer)
                    passive.HandlePassiveEffect(opposingPlayer);
                else
                    passive.HandlePassiveEffect(currentPlayer);
            }
        }
    }
}
