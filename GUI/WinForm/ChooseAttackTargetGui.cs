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
    public partial class ChooseAttackTargetGui : Form
    {
        readonly static int buttonWidth = 140;
        readonly static int buttonHeight = 40;
        readonly static int padding = 1;

        public Targetable Target { get; private set; }

        private Player inactivePlayer;

        public ChooseAttackTargetGui()
        {
            InitializeComponent();
            inactivePlayer = GamePhaseManager.Instance.InactivePlayer;
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            AttackOtherPlayerButton.Text = $"Attack {inactivePlayer.Name}";
            AttackOtherPlayerButton.Click += AttackOtherPlayerButton_Click;

            // TODO refactor WinFormUtil to accept List<T> instead of List<Item>
            for (int i = 0; i < inactivePlayer.Constructs.Count; i++)
            {
                Button button = new Button()
                {
                    Text = inactivePlayer.Constructs[i].Strength.ToString(),
                    Size = new Size(buttonWidth, buttonHeight),
                    Margin = new Padding(padding),
                    Tag = i,
                    AutoSize = true
                };
                button.Click += AttackConstructButton_Click;
                ConstructsPanel.Controls.Add(button);
            }
        }

        private void AttackOtherPlayerButton_Click(object sender, EventArgs e)
        {
            Target = inactivePlayer;
            Close();
        }

        private void AttackConstructButton_Click(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            Target = inactivePlayer.Constructs[(int) pressedButton.Tag];
            Close();
        }
    }
}
