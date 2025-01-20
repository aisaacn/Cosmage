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

        readonly int buttonWidth = 121;
        readonly int buttonHeight = 42;
        readonly int padding = 5;

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
            GenerateEssenceButtons();
            GenerateCatalystButtons();
        }

        private void GenerateEssenceButtons()
        {
            for (int i = 0; i < essences.Count; i++)
            {
                Button button = new Button
                {
                    Text = essences[i].Name,
                    Size = new Size(buttonWidth, buttonHeight),
                    Margin = new Padding(padding),
                    Tag = i
                };
                button.Click += EssenceButton_Click;
                EssencePanel.Controls.Add(button);
            }
        }

        private void GenerateCatalystButtons()
        {
            // TODO simplify duplicate code
            for (int i = 0; i < catalysts.Count; i++)
            {
                Button button = new Button
                {
                    Text = catalysts[i].Name,
                    Size = new Size(buttonWidth, buttonHeight),
                    Margin = new Padding(padding),
                    Tag = i
                };
                button.Click += CatalystButton_Click;
                CatalystPanel.Controls.Add(button);
            }
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
