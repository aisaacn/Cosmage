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

        public ConsumablePhaseGui(List<Consumable> items)
        {
            InitializeComponent();
            consumables = items;
            isFinished = false;
            WinFormUtil.PopulateControlWithButtonsFromList(ConsumablePanel, consumables.Cast<Item>().ToList(), false, ConsumableButton_Click);
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
