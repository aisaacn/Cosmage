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
    partial class GUIForm : Form
    {
        GamePhaseManager gamePhaseManager;

        public GUIForm()
        {
            gamePhaseManager = GamePhaseManager.Instance;
            InitializeComponent();
            ToggleButtonVisibility(false);
        }

        private void ToggleButtonVisibility(bool show)
        {
            // TODO better way to modify UI
            if (show)
            {

                AddBasicIngredientButton.Show();
                AddAttackCrystalButton.Show();
            }
            else
            {
                AddBasicIngredientButton.Hide();
                AddAttackCrystalButton.Hide();
            }
        }

        private void AddBasicIngredient_Click(object sender, EventArgs e)
        {
            if (gamePhaseManager.GetCurrentPhase() != GamePhase.GamePhase.Ingredient)
            {
                Console.WriteLine("not ingredient phase");
            }
            // TODO communicate with Player class
            Console.WriteLine("add ingredient button pressed during ingredient phase!");
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            gamePhaseManager.StartGame();
            StartGameButton.Dispose();
            ToggleButtonVisibility(true);
        }

        private void AddAttackCrystal_Click(object sender, EventArgs e)
        {
            // TODO catalysts
        }
    }
}