using CosmageV2.PlayerInteraction;
using CosmageV2.PlayerInteraction.Itemization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace CosmageV2.GUI
{
    public partial class IngredientPhaseGuiCustomSatchel : Form
    {
        public Ingredient selectedIngredient;
        public bool isAddingIngredient;
        public bool isCatalyst;

        private List<Essence> essences;
        private List<Catalyst> catalysts;

        public IngredientPhaseGuiCustomSatchel(Satchel satchel)
        {
            InitializeComponent();
            essences = satchel.Essences;
            catalysts = satchel.Catalysts;
            isAddingIngredient = true;
            isCatalyst = false;
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            WinFormUtil.PopulateControlWithButtonsFromList(EssencePanel, essences.Cast<Item>().ToList(), EssenceButton_Click);
            WinFormUtil.PopulateControlWithButtonsFromList(CatalystPanel, catalysts.Cast<Item>().ToList(), CatalystButton_Click);
        }

        private void EssenceButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int index = (int) clickedButton.Tag;
            selectedIngredient = essences[index];
            Close();
        }

        private void CatalystButton_Click(Object sender, EventArgs e)
        {
            isCatalyst = true;
            Button clickedButton = sender as Button;
            int index = (int)clickedButton.Tag;
            selectedIngredient = catalysts[index];
            Close();
        }

        private void None_Click(object sender, EventArgs e)
        {
            isAddingIngredient = false;
            Close();
        }
    }
}
