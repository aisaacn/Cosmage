using CosmageV2.GamePhase;
using CosmageV2.PlayerInteraction;
using CosmageV2.PlayerInteraction.Itemization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CosmageV2.GUI
{
    /*
     * GUI for customizing all aspects of Player, including Name, Element, and Satchel.
     * Created 1/20/25
     */
    public partial class PlayerCreatorGui : Form
    {
        public Player Player { get; private set; }
        private List<Item> satchel;
        private string name;
        private Element element;

        private List<Essence> essenceOptions;
        private List<Catalyst> catalystOptions;
        private List<Consumable> consumableOptions;
        private List<PassiveItem> passiveOptions;

        public PlayerCreatorGui(Player player)
        {
            InitializeComponent();
            satchel = new List<Item>();

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
            satchel = existingPlayer.Satchel.Clone().AllItems;

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

            satchel.Add(essenceOptions[index]);
            UpdateSatchelContents();
        }

        private void AddCatalyst_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int index = (int) clickedButton.Tag;
            Catalyst catalyst = catalystOptions[index];

            if (catalyst.IsReusable)
            {
                if (satchel.Contains(catalyst))
                {
                    //Console.WriteLine($"No need for multiple {catalyst.Name}s");
                    return;
                }
            }

            satchel.Add(catalyst);
            UpdateSatchelContents();
        }

        private void AddConsumable_Click(object sender, EventArgs e)
        {
            // TODO simplify these click handlers to one method
            Button clickedButton = sender as Button;
            int index = (int) clickedButton.Tag;

            satchel.Add(consumableOptions[index]);
            UpdateSatchelContents();
        }

        private void AddPassive_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int index = (int) clickedButton.Tag;

            satchel.Add(passiveOptions[index]);
            UpdateSatchelContents();
        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int index = (int) clickedButton.Tag;

            satchel.RemoveAt(index);
            UpdateSatchelContents();
        }

        private void UpdateSatchelContents()
        {
            CurrentSatchelPanel.Controls.Clear();
            SatchelWeightLabel.ForeColor = Color.Black;
            WinFormUtil.PopulateControlWithButtonsFromList(CurrentSatchelPanel, satchel, true, RemoveItem_Click);

            int maxWeight = GamePhaseManager.Instance.RulesetManager.SatchelMaxWeight;
            int weight = satchel.Sum(item => item.SatchelWeight);
            SatchelWeightLabel.Text = $"{weight.ToString()}/{maxWeight}";
            if (weight > maxWeight) SatchelWeightLabel.ForeColor = Color.Red;
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
                UpdateExistingPlayerInfo(SamplePlayers.GetPlayer(selection));
            }
        }

        private void SaveNewSamplePlayer()
        {
            if (GetName() && GetElement())
            {
                Player samplePlayer = new Player(element, name);
                samplePlayer.SetSatchel(new Satchel(satchel));
                SamplePlayers.AddCustomSamplePlayer(samplePlayer);

                SamplePlayerList.SelectedText = samplePlayer.Name;
                UpdateSatchelContents();
                GenerateSamplePlayers();
            }
        }

        private void GenerateButtons()
        {
            WinFormUtil.PopulateControlWithButtonsFromList(EssencePanel, essenceOptions.Cast<Item>().ToList(), true, AddEssence_Click);
            WinFormUtil.PopulateControlWithButtonsFromList(CatalystPanel, catalystOptions.Cast<Item>().ToList(), true, AddCatalyst_Click);
            WinFormUtil.PopulateControlWithButtonsFromList(ConsumablePanel, consumableOptions.Cast<Item>().ToList(), true, AddConsumable_Click);
            WinFormUtil.PopulateControlWithButtonsFromList(PassivePanel, passiveOptions.Cast<Item>().ToList(), true, AddPassive_Click);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (GetName() && GetElement())
            {
                Player = new Player(element, name); // TODO pass ruleset and gui here? 
                Player.SetSatchel(new Satchel(satchel));
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
