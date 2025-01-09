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
        public int RuneChargeIndex { get; private set; }
        public int RuneActivateIndex { get; private set; }

        public RunePhaseGui()
        {
            // TODO get rune names from Player
            InitializeComponent();
            RuneChargeIndex = -2;
            RuneActivateIndex = -2;
        }

        private void RunePhaseGui_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            GetChargedRune();
            GetActivatedRune();
            if (RuneChargeIndex != -2 && RuneActivateIndex != -2) Close();
        }

        private void GetChargedRune()
        {
            if (Rune1ChargeOption.Checked) RuneChargeIndex = 0;

            if (Rune2ChargeOption.Checked) RuneChargeIndex = 1;

            if (Rune3ChargeOption.Checked) RuneChargeIndex = 2;
        }

        private void GetActivatedRune()
        {
            if (Rune1ActivateOption.Checked) RuneActivateIndex = 0;

            if (Rune2ActivateOption.Checked) RuneActivateIndex = 1;

            if (Rune3ActivateOption.Checked) RuneActivateIndex = 2;

            if (NoneActivationOption.Checked) RuneActivateIndex = -1;
        }
    }
}
