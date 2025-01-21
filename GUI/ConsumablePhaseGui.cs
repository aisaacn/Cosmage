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

namespace CosmageV2.GUI
{
    public partial class ConsumablePhaseGui : Form
    {
        public Consumable selectedConsumable;
        public bool isFinished;

        private List<Consumable> consumables;

        readonly int buttonWidth = 121;
        readonly int buttonHeight = 42;
        readonly int padding = 5;

        public ConsumablePhaseGui(List<Consumable> items)
        {
            InitializeComponent();
            consumables = items;
            isFinished = false;
            GenerateConsumableButtons();
        }

        private void GenerateConsumableButtons()
        {
            for (int i = 0; i < consumables.Count; i++)
            {
                Button button = new Button()
                {
                    Text = consumables[i].Name,
                    Size = new Size(buttonWidth, buttonHeight),
                    Margin = new Padding(padding),
                    Tag = i
                };
                button.Click += ConsumableButton_Click;
                ConsumablePanel.Controls.Add(button);
            }
        }

        private void ConsumableButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int index = (int) clickedButton.Tag;
            selectedConsumable = consumables[index];
            Close();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            isFinished = true;
            Close();
        }
    }
}
