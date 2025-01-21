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
using System.Windows.Media.Imaging;

namespace CosmageV2.GUI
{
    /*
     * GUI for customizing all aspects of Player, including Name, Element, and Satchel.
     * Created 1/20/25
     */
    public partial class PlayerCreatorGui : Form
    {
        public Player Player { get; private set; }
        private Satchel satchel;
        private string name;
        private Element element;

        private List<Essence> essenceOptions;
        private List<Catalyst> catalystOptions;
        private List<Consumable> consumableOptions;
        private List<PassiveItem> passiveOptions;

        readonly int buttonWidth = 120;
        readonly int buttonHeight = 35;
        readonly int padding = 5;

        public PlayerCreatorGui(Player player)
        {
            InitializeComponent();
            satchel = new Satchel();

            if (player != null)
            {
                UpdateExistingPlayerInfo(player);
            }

            CreateItemOptions();
            GenerateButtons();
            GenerateSamplePlayers();
        }

        private void UpdateExistingPlayerInfo(Player existingPlayer)
        {
            PlayerName.Text = existingPlayer.Name;
            satchel = existingPlayer.Satchel.Clone();

            switch (existingPlayer.Element)
            {
                case Element.Natural:
                    NaturalButton.Checked = true;
                    break;

                case Element.Mechanical:
                    MechanicalButton.Checked = true;
                    break;

                case Element.Unnatural:
                    UnnaturalButton.Checked = true;
                    break;
            }
            UpdateSatchelContents();
        }

        private void AddEssence_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int index = (int) clickedButton.Tag;

            satchel.AddItem(essenceOptions[index]);
            UpdateSatchelContents();
        }

        private void AddCatalyst_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int index = (int) clickedButton.Tag;
            Catalyst catalyst = catalystOptions[index];

            if (catalyst.IsReusable)
            {
                if (satchel.Catalysts.Contains(catalyst))
                {
                    //Console.WriteLine($"No need for multiple {catalyst.Name}s");
                    return;
                }
            }

            satchel.AddItem(catalyst);
            UpdateSatchelContents();
        }

        private void AddConsumable_Click(object sender, EventArgs e)
        {
            // TODO simplify these three click handlers to one method
            Button clickedButton = sender as Button;
            int index = (int) clickedButton.Tag;

            satchel.AddItem(consumableOptions[index]);
            UpdateSatchelContents();
        }

        private void AddPassive_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int index = (int) clickedButton.Tag;

            satchel.AddItem(passiveOptions[index]);
            UpdateSatchelContents();
        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Item item = (Item) clickedButton.Tag;

            satchel.RemoveItem(item);
            UpdateSatchelContents();
        }

        private void UpdateSatchelContents()
        {
            CurrentSatchelPanel.Controls.Clear();

            for (int i = 0; i < satchel.AllItems.Count; i++)
            {
                Button button = new Button()
                {
                    Text = $"{satchel.AllItems[i].Name} ({satchel.AllItems[i].SatchelWeight})",
                    Size = new Size(buttonWidth, buttonHeight),
                    Margin = new Padding(padding),
                    Tag = satchel.AllItems[i]
                };
                button.Click += RemoveItem_Click;
                CurrentSatchelPanel.Controls.Add(button);
            }

            SatchelWeightLabel.Text = satchel.TotalWeight.ToString();
        }

        private void CreateItemOptions()
        {
            essenceOptions = ItemRegistry.Essences.Options;
            catalystOptions = ItemRegistry.Catalysts.Options;
            consumableOptions = ItemRegistry.Consumables.Options;
            passiveOptions = ItemRegistry.PassiveItems.Options;
        }

        private void GenerateSamplePlayers()
        {
            SamplePlayerList.Items.Clear();
            foreach (string playerName in SamplePlayers.Samples.Keys)
            {
                SamplePlayerList.Items.Add(playerName);
            }
            SamplePlayerList.Items.Add("Create new sample player...");
        }

        private void SamplePlayer_Select(object sender, EventArgs e)
        {
            string selection = (string) SamplePlayerList.SelectedItem;
            if (selection.Equals("Create new sample player..."))
            {
                SaveNewSamplePlayer();
            }
            else
            {
                UpdateExistingPlayerInfo(SamplePlayers.Samples[selection]);
            }
        }

        private void SaveNewSamplePlayer()
        {
            if (GetName() && GetElement())
            {
                Player samplePlayer = new Player(element, name);
                samplePlayer.SetSatchel(satchel);
                SamplePlayers.AddCustomSamplePlayer(samplePlayer);

                SamplePlayerList.SelectedText = samplePlayer.Name;
                UpdateSatchelContents();
                GenerateSamplePlayers();
            }
        }

        private void GenerateButtons()
        {
            GenerateIngredientButtons();
            GenerateCatalystButtons();
            GenerateConsumableButtons();
            GeneratePassiveButtons();
        }

        private void GenerateIngredientButtons()
        {
            for (int i = 0; i < essenceOptions.Count; i++)
            {
                Button button = new Button
                {
                    Text = $"{essenceOptions[i].Name} ({essenceOptions[i].SatchelWeight})",
                    Size = new Size(buttonWidth, buttonHeight),
                    Margin = new Padding(padding),
                    Tag = i
                };
                button.Click += AddEssence_Click;
                EssencePanel.Controls.Add(button);
            }
        }

        private void GenerateCatalystButtons()
        {
            for (int i = 0; i < catalystOptions.Count; i++)
            {
                Button button = new Button
                {
                    Text = $"{catalystOptions[i].Name} ({catalystOptions[i].SatchelWeight})",
                    Size = new Size(buttonWidth, buttonHeight),
                    Margin = new Padding(padding),
                    Tag = i
                };
                button.Click += AddCatalyst_Click;
                CatalystPanel.Controls.Add(button);
            }
        }

        private void GenerateConsumableButtons()
        {
            for (int i = 0; i < consumableOptions.Count; i++)
            {
                Button button = new Button
                {
                    Text = $"{consumableOptions[i].Name} ({consumableOptions[i].SatchelWeight})",
                    Size = new Size(buttonWidth, buttonHeight),
                    Margin = new Padding(padding),
                    Tag = i
                };
                button.Click += AddConsumable_Click;
                ConsumablePanel.Controls.Add(button);
            }
        }

        private void GeneratePassiveButtons()
        {
            for (int i = 0; i < passiveOptions.Count; i++)
            {
                Button button = new Button()
                {
                    Text = $"{passiveOptions[i].Name} ({passiveOptions[i].SatchelWeight})",
                    Size = new Size(buttonWidth, buttonHeight),
                    Margin = new Padding(padding),
                    Tag = i
                };
                button.Click += AddPassive_Click;
                PassivePanel.Controls.Add(button);
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (GetName() && GetElement())
            {
                Player = new Player(element, name);
                Player.SetSatchel(satchel);
                Close();
            }
        }

        private bool GetName()
        {
            name = PlayerName.Text.Trim();
            if (name == String.Empty) return false;
            return true;
        }

        private bool GetElement()
        {
            if (NaturalButton.Checked) element = Element.Natural;
            else if (MechanicalButton.Checked) element = Element.Mechanical;
            else if (UnnaturalButton.Checked) element = Element.Unnatural;
            else return false;
            return true;
        }
    }
}
