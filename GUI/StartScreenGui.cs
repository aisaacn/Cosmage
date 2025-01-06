using CosmageV2.GamePhase;
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
        public StartScreenGui()
        {
            InitializeComponent();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            // this.Close();
            this.Hide();
            GamePhaseManager.Instance.StartGame();
        }
    }
}
