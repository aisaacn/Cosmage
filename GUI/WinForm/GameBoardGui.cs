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
        Dictionary<Player, Label> nameByPlayer;
        Dictionary<Player, Label> cauldronByPlayer;
        Dictionary<Player, Label> catalystByPlayer;
        Dictionary<Player, Label> runeNamesByPlayer;
        Dictionary<Player, Label> runeStatusByPlayer;
        Dictionary<Player, Label> wardByPlayer;
        Dictionary<Player, Label> constructsByPlayer;
        Dictionary<Player, Label> healthByPlayer;

        public GameBoardGui()
        {
            InitializeComponent();
            CreateLabelDicts();

            this.FormClosing += (s, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            };
        }

        private void CreateLabelDicts()
        {
            nameByPlayer = new Dictionary<Player, Label>();
            cauldronByPlayer = new Dictionary<Player, Label>();
            catalystByPlayer = new Dictionary<Player, Label>();
            runeNamesByPlayer = new Dictionary<Player, Label>();
            runeStatusByPlayer = new Dictionary<Player, Label>();
            wardByPlayer = new Dictionary<Player, Label>();
            constructsByPlayer = new Dictionary<Player, Label>();
            healthByPlayer = new Dictionary<Player, Label>();
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

            // Wards
            wardByPlayer.Add(player1, Player1Ward);
            wardByPlayer.Add(player2, Player2Ward);

            // Constructs
            constructsByPlayer.Add(player1, Player1Constructs);
            constructsByPlayer.Add(player2, Player2Constructs);

            // Health
            healthByPlayer.Add(player1, Player1Health);
            healthByPlayer.Add(player2, Player2Health);

            // Player Names
            nameByPlayer.Add(player1, Player1CauldronLabel);
            nameByPlayer.Add(player2, Player2CauldronLabel);
            Player1CauldronLabel.Text = $"{player1.Name}-{player1.Element}:";
            Player2CauldronLabel.Text = $"{player2.Name}-{player2.Element}:";

            UpdatePlayerLabels(player1);
            UpdatePlayerLabels(player2);
        }

        public void UpdatePlayerLabels(Player player)
        {
            Label cauldronLabel = cauldronByPlayer[player];
            Label catalystLabel = catalystByPlayer[player];
            Label runeNamesLabel = runeNamesByPlayer[player];
            Label runeStatusLabel = runeStatusByPlayer[player];
            Label wardLabel = wardByPlayer[player];
            Label constructsLabel = constructsByPlayer[player];
            Label healthLabel = healthByPlayer[player];

            cauldronLabel.Text = "Cauldron: " + player.Cauldron.ToString();
            catalystLabel.Text = "Catalyst: " + player.Catalyst.ToString();
            runeNamesLabel.Text = player.RuneNamesToString();
            runeStatusLabel.Text = player.RuneStatusToString();
            wardLabel.Text = "Ward: " + player.Ward.ToString();
            constructsLabel.Text = player.ConstructsToString();
            healthLabel.Text = player.Health + " HP";
        }

        public void UpdateCurrentPlayer(Player player)
        {
            // TODO better way to get other player label?
            foreach (Player p in nameByPlayer.Keys)
            {
                if (p.Equals(player)) nameByPlayer[p].ForeColor = Color.Green;
                else nameByPlayer[p].ForeColor = Color.Black;
            }
        }

        public void ShowWinner(Player player)
        {
            //CurrentPlayerLabel.Text = $"{player.Name} wins!";
            LogEvent($"{player.Name} wins!");
        }

        public void LogEvent(String log)
        {
            Label label = new Label()
            {
                Text = log,
                AutoSize = true
            };
            EventLogPanel.Controls.Add(label);
            EventLogPanel.ScrollControlIntoView(label);
        }
    }
}
