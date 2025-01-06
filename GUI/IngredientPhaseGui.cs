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
    public partial class IngredientPhaseGui : Form
    {
        public bool isCatalyst;
        public ElementalStrength strength;

        public IngredientPhaseGui()
        {
            InitializeComponent();
            isCatalyst = false;
        }

        private void AddBasicNatural_Click(object sender, EventArgs e)
        {
            strength = new ElementalStrength(1, 0, 0);
            this.Close();
        }

        private void AddBasicMechanical_Click(object sender, EventArgs e)
        {
            strength = new ElementalStrength(0, 1, 0);
            this.Close();
        }

        private void AddBasicUnnatural_Click(object sender, EventArgs e)
        {
            strength = new ElementalStrength(0, 0, 1);
            this.Close();
        }

        private void AddAdvNatural_Click(object sender, EventArgs e)
        {
            strength = new ElementalStrength(2, 0, 0);
            this.Close();
        }

        private void AddAdvMechanical_Click(object sender, EventArgs e)
        {
            strength = new ElementalStrength(0, 2, 0);
            this.Close();
        }
        private void AddAdvUnnatural_Click(object sender, EventArgs e)
        {
            strength = new ElementalStrength(0, 0, 2);
            this.Close();
        }

        private void AddAttackCrystal_Click(object sender, EventArgs e)
        {
            isCatalyst = true;
            this.Close();
            // TODO
        }

        private void AddWardCrystal_Click(object sender, EventArgs e)
        {
            isCatalyst = true;
            this.Close();
            // TODO
        }

        private void AddConstructCrystal_Click(object sender, EventArgs e)
        {
            isCatalyst = true;
            this.Close();
            // TODO
        }
    }
}
