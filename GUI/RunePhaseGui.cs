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
    public partial class RunePhaseGui : Form
    {
        public bool ActivateRune {  get; private set; }
        public int ChargedRuneIndex { get; private set; }

        public RunePhaseGui()
        {
            InitializeComponent();
            ActivateRune = false;
            ChargedRuneIndex = -1;
            // TODO retrieve and display runes from current player (probably shouldn't rely on PlayerInteraction, ideally should be clickable from GameBoard gui)
        }

        private void RunePhaseGui_Load(object sender, EventArgs e)
        {

        }

        private void ChargeRune1Button_Click(object sender, EventArgs e)
        {
            ChargedRuneIndex = 0;
        }

        private void ChargeRune2Button_Click(object sender, EventArgs e)
        {
            ChargedRuneIndex = 1;
        }

        private void ChargeRune3Button_Click(object sender, EventArgs e)
        {
            ChargedRuneIndex = 2;
        }

        private void ChargeAndActivateButton_Click(object sender, EventArgs e)
        {
            if (ChargedRuneIndex != -1)
            {
                ActivateRune = true;
                Close();
            }
        }

        private void ChargeButton_Click(object sender, EventArgs e)
        {
            if (ChargedRuneIndex != -1)
            {
                Close();
            }
        }
    }
}
