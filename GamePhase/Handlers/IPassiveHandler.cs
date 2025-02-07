using CosmageV2.PlayerInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    public interface IPassiveHandler
    {
        /// <summary>
        /// Adjusts game and Player status according to each Player's Passive Items.
        /// </summary>
        void HandlePassives(Player player1, Player player2);
    }
}
