using CosmageV2.PlayerInteraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmageV2.GUI
{
    public partial class GameBoardGui : Form
    {
        Dictionary<Player, Label> cauldronByPlayer;
        Dictionary<Player, Label> catalystByPlayer;
        Dictionary<Player, Label> runeNamesByPlayer;
        Dictionary<Player, Label> runeStatusByPlayer;

        public GameBoardGui()
        {
            InitializeComponent();
            cauldronByPlayer = new Dictionary<Player, Label>();
            catalystByPlayer = new Dictionary<Player, Label>();
            runeNamesByPlayer = new Dictionary<Player, Label>();
            runeStatusByPlayer = new Dictionary<Player, Label>();
        }

        private void GameBoardGui_Load(object sender, EventArgs e)
        {

        }

        public void AssignPlayersToLabels(Player player1, Player player2)
        {
            // Cauldrons
            cauldronByPlayer.Add(player1, Player1CauldronContents);
            cauldronByPlayer.Add(player2, Player2CauldronContents);

            // Catalysts
            catalystByPlayer.Add(player1, Player1Catalyst);
            catalystByPlayer.Add(player2, Player2Catalyst);

            // Rune Names
            runeNamesByPlayer.Add(player1, Player1RuneNames);
            runeNamesByPlayer.Add(player2, Player2RuneNames);

            // Rune Status
            runeStatusByPlayer.Add(player1, Player1RuneStatus);
            runeStatusByPlayer.Add(player2, Player2RuneStatus);

            // Player Names
            Player1CauldronLabel.Text = player1.Name + "'s Cauldron:";
            Player2CauldronLabel.Text = player2.Name + "'s Cauldron:";

            UpdatePlayerLabels(player1);
            UpdatePlayerLabels(player2);
        }

        public void UpdatePlayerLabels(Player player)
        {
            Label cauldronLabel = cauldronByPlayer[player];
            Label catalystLabel = catalystByPlayer[player];
            Label runeNamesLabel = runeNamesByPlayer[player];
            Label runeStatusLabel = runeStatusByPlayer[player];

            cauldronLabel.Text = player.Cauldron.ToString();
            catalystLabel.Text = "Catalyst: " + player.Catalyst.ToString();
            runeNamesLabel.Text = player.RuneNamesToString();
            runeStatusLabel.Text = player.RuneStatusToString();
        }

        public void UpdateCurrentPlayer(Player player)
        {
            CurrentPlayerLabel.Text = "Current Player: " + player.Name;
        }
    }
}
