using CosmageV2.GamePhase;
using CosmageV2.PlayerInteraction;
using CosmageV2.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmageV2
{
    internal class GameRunner
    {
        static void Main()
        {
            Form gui = new GUIForm();

            Player player1 = new Player(Element.Natural, "Player1-N");
            Player player2 = new Player(Element.Mechanical, "Player2-M");

            // TODO refactor to use IGamePhaseManager type instead. Allows for multiple rule sets, additional players, etc
            GamePhaseManager manager = GamePhaseManager.Instance;
            manager.AddPlayers(player1, player2);

            gui.ShowDialog();
            // manager.StartGame();
        }
    }
}