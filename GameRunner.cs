using CosmageV2.GamePhase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2
{
    internal class GameRunner
    {
        static void Main()
        {
            Player player1 = new Player(Element.Natural, "Player1-N");
            Player player2 = new Player(Element.Mechanical, "Player2-M");

            GamePhaseManager manager = GamePhaseManager.Instance;
            manager.AddPlayers(player1, player2);
            manager.StartGame();
        }
    }
}
