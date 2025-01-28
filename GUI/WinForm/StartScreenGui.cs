using CosmageV2.GamePhase;
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
    public partial class StartScreenGui : Form
    {
        public Player player1;
        public Player player2;

        public StartScreenGui()
        {
            InitializeComponent();
            UpdatePlayerInfo();
        }

        private void UpdatePlayerInfo()
        {
            if (player1 == null) CreatePlayer1Button.Text = "Create Player 1";
            else CreatePlayer1Button.Text = $"Modify {player1.Name}";

            if (player2 == null) CreatePlayer2Button.Text = "Create Player 2";
            else CreatePlayer2Button.Text = $"Modify {player2.Name}";
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            if (player1 != null && player2 != null)
            {
                GamePhaseManager.Instance.SetPlayers(player1, player2);
                GameBoardGui gameBoard = new GameBoardGui();
                GamePhaseManager.Instance.SetGameBoard(gameBoard);
                this.Hide();

                Task.Run(() =>
                {
                    GamePhaseManager.Instance.StartGame();
                });

                if (gameBoard.ShowDialog() == DialogResult.Cancel)
                {
                    //this.Show(); //leave this if you want the StartScreenGui to show again after closing GameBoard
                }
            } 
        }

        private void CreatePlayer1Button_Click(object sender, EventArgs e)
        {
            player1 = OpenPlayerCreatorGui(player1);
            UpdatePlayerInfo();
        }

        private void CreatePlayer2Button_Click(object sender, EventArgs e)
        {
            player2 = OpenPlayerCreatorGui(player2);
            UpdatePlayerInfo();
        }

        private Player OpenPlayerCreatorGui(Player player)
        {
            PlayerCreatorGui gui = new PlayerCreatorGui(player);
            gui.ShowDialog();

            return gui.Player;
        }
    }
}
