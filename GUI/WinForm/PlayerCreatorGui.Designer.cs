namespace CosmageV2.GUI
{
    partial class PlayerCreatorGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ElementBox = new System.Windows.Forms.GroupBox();
            this.UnnaturalButton = new System.Windows.Forms.RadioButton();
            this.MechanicalButton = new System.Windows.Forms.RadioButton();
            this.NaturalButton = new System.Windows.Forms.RadioButton();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentSatchelPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CurrentSatchelLabel = new System.Windows.Forms.Label();
            this.SatchelWeightLabel = new System.Windows.Forms.Label();
            this.EssencePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CatalystPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.essenceLabel = new System.Windows.Forms.Label();
            this.catalystLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SamplePlayerList = new System.Windows.Forms.ComboBox();
            this.ConsumablePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.consumableLabel = new System.Windows.Forms.Label();
            this.PassivePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.passiveLabel = new System.Windows.Forms.Label();
            this.ElementBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElementBox
            // 
            this.ElementBox.Controls.Add(this.UnnaturalButton);
            this.ElementBox.Controls.Add(this.MechanicalButton);
            this.ElementBox.Controls.Add(this.NaturalButton);
            this.ElementBox.Location = new System.Drawing.Point(12, 12);
            this.ElementBox.Name = "ElementBox";
            this.ElementBox.Size = new System.Drawing.Size(405, 79);
            this.ElementBox.TabIndex = 0;
            this.ElementBox.TabStop = false;
            this.ElementBox.Text = "Select Player Element:";
            // 
            // UnnaturalButton
            // 
            this.UnnaturalButton.AutoSize = true;
            this.UnnaturalButton.Location = new System.Drawing.Point(277, 34);
            this.UnnaturalButton.Name = "UnnaturalButton";
            this.UnnaturalButton.Size = new System.Drawing.Size(104, 24);
            this.UnnaturalButton.TabIndex = 2;
            this.UnnaturalButton.TabStop = true;
            this.UnnaturalButton.Text = "Unnatural";
            this.UnnaturalButton.UseVisualStyleBackColor = true;
            // 
            // MechanicalButton
            // 
            this.MechanicalButton.AutoSize = true;
            this.MechanicalButton.Location = new System.Drawing.Point(133, 34);
            this.MechanicalButton.Name = "MechanicalButton";
            this.MechanicalButton.Size = new System.Drawing.Size(114, 24);
            this.MechanicalButton.TabIndex = 1;
            this.MechanicalButton.TabStop = true;
            this.MechanicalButton.Text = "Mechanical";
            this.MechanicalButton.UseVisualStyleBackColor = true;
            // 
            // NaturalButton
            // 
            this.NaturalButton.AutoSize = true;
            this.NaturalButton.Location = new System.Drawing.Point(19, 34);
            this.NaturalButton.Name = "NaturalButton";
            this.NaturalButton.Size = new System.Drawing.Size(85, 24);
            this.NaturalButton.TabIndex = 0;
            this.NaturalButton.TabStop = true;
            this.NaturalButton.Text = "Natural";
            this.NaturalButton.UseVisualStyleBackColor = true;
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(455, 44);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(333, 26);
            this.PlayerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Player Name:";
            // 
            // CurrentSatchelPanel
            // 
            this.CurrentSatchelPanel.AutoScroll = true;
            this.CurrentSatchelPanel.Location = new System.Drawing.Point(12, 359);
            this.CurrentSatchelPanel.Name = "CurrentSatchelPanel";
            this.CurrentSatchelPanel.Size = new System.Drawing.Size(1034, 252);
            this.CurrentSatchelPanel.TabIndex = 4;
            // 
            // CurrentSatchelLabel
            // 
            this.CurrentSatchelLabel.AutoSize = true;
            this.CurrentSatchelLabel.Location = new System.Drawing.Point(8, 336);
            this.CurrentSatchelLabel.Name = "CurrentSatchelLabel";
            this.CurrentSatchelLabel.Size = new System.Drawing.Size(178, 20);
            this.CurrentSatchelLabel.TabIndex = 0;
            this.CurrentSatchelLabel.Text = "Current Satchel Weight:";
            // 
            // SatchelWeightLabel
            // 
            this.SatchelWeightLabel.AutoSize = true;
            this.SatchelWeightLabel.Location = new System.Drawing.Point(192, 336);
            this.SatchelWeightLabel.Name = "SatchelWeightLabel";
            this.SatchelWeightLabel.Size = new System.Drawing.Size(18, 20);
            this.SatchelWeightLabel.TabIndex = 5;
            this.SatchelWeightLabel.Text = "0";
            // 
            // EssencePanel
            // 
            this.EssencePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.EssencePanel.Location = new System.Drawing.Point(12, 115);
            this.EssencePanel.Name = "EssencePanel";
            this.EssencePanel.Size = new System.Drawing.Size(386, 218);
            this.EssencePanel.TabIndex = 6;
            // 
            // CatalystPanel
            // 
            this.CatalystPanel.AutoScroll = true;
            this.CatalystPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CatalystPanel.Location = new System.Drawing.Point(404, 115);
            this.CatalystPanel.Name = "CatalystPanel";
            this.CatalystPanel.Size = new System.Drawing.Size(200, 218);
            this.CatalystPanel.TabIndex = 7;
            this.CatalystPanel.WrapContents = false;
            // 
            // essenceLabel
            // 
            this.essenceLabel.AutoSize = true;
            this.essenceLabel.Location = new System.Drawing.Point(12, 92);
            this.essenceLabel.Name = "essenceLabel";
            this.essenceLabel.Size = new System.Drawing.Size(132, 20);
            this.essenceLabel.TabIndex = 8;
            this.essenceLabel.Text = "Select Essences:";
            // 
            // catalystLabel
            // 
            this.catalystLabel.AutoSize = true;
            this.catalystLabel.Location = new System.Drawing.Point(400, 92);
            this.catalystLabel.Name = "catalystLabel";
            this.catalystLabel.Size = new System.Drawing.Size(127, 20);
            this.catalystLabel.TabIndex = 9;
            this.catalystLabel.Text = "Select Catalysts:";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(734, 617);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(175, 35);
            this.ConfirmButton.TabIndex = 10;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SamplePlayerList
            // 
            this.SamplePlayerList.FormattingEnabled = true;
            this.SamplePlayerList.Location = new System.Drawing.Point(101, 624);
            this.SamplePlayerList.Name = "SamplePlayerList";
            this.SamplePlayerList.Size = new System.Drawing.Size(256, 28);
            this.SamplePlayerList.TabIndex = 11;
            this.SamplePlayerList.Text = "Choose Sample Player...";
            this.SamplePlayerList.SelectedIndexChanged += new System.EventHandler(this.SamplePlayer_Select);
            // 
            // ConsumablePanel
            // 
            this.ConsumablePanel.AutoScroll = true;
            this.ConsumablePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ConsumablePanel.Location = new System.Drawing.Point(607, 115);
            this.ConsumablePanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ConsumablePanel.Name = "ConsumablePanel";
            this.ConsumablePanel.Size = new System.Drawing.Size(220, 218);
            this.ConsumablePanel.TabIndex = 8;
            this.ConsumablePanel.WrapContents = false;
            // 
            // consumableLabel
            // 
            this.consumableLabel.AutoSize = true;
            this.consumableLabel.Location = new System.Drawing.Point(603, 92);
            this.consumableLabel.Name = "consumableLabel";
            this.consumableLabel.Size = new System.Drawing.Size(159, 20);
            this.consumableLabel.TabIndex = 12;
            this.consumableLabel.Text = "Select Consumables:";
            // 
            // PassivePanel
            // 
            this.PassivePanel.AutoScroll = true;
            this.PassivePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PassivePanel.Location = new System.Drawing.Point(830, 115);
            this.PassivePanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.PassivePanel.Name = "PassivePanel";
            this.PassivePanel.Size = new System.Drawing.Size(220, 218);
            this.PassivePanel.TabIndex = 9;
            this.PassivePanel.WrapContents = false;
            // 
            // passiveLabel
            // 
            this.passiveLabel.AutoSize = true;
            this.passiveLabel.Location = new System.Drawing.Point(826, 92);
            this.passiveLabel.Name = "passiveLabel";
            this.passiveLabel.Size = new System.Drawing.Size(160, 20);
            this.passiveLabel.TabIndex = 13;
            this.passiveLabel.Text = "Select Passive Items:";
            // 
            // PlayerCreatorGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.passiveLabel);
            this.Controls.Add(this.PassivePanel);
            this.Controls.Add(this.consumableLabel);
            this.Controls.Add(this.ConsumablePanel);
            this.Controls.Add(this.SamplePlayerList);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.catalystLabel);
            this.Controls.Add(this.essenceLabel);
            this.Controls.Add(this.CatalystPanel);
            this.Controls.Add(this.EssencePanel);
            this.Controls.Add(this.SatchelWeightLabel);
            this.Controls.Add(this.CurrentSatchelLabel);
            this.Controls.Add(this.CurrentSatchelPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.ElementBox);
            this.Name = "PlayerCreatorGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerCreatorGui";
            this.ElementBox.ResumeLayout(false);
            this.ElementBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ElementBox;
        private System.Windows.Forms.RadioButton UnnaturalButton;
        private System.Windows.Forms.RadioButton MechanicalButton;
        private System.Windows.Forms.RadioButton NaturalButton;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel CurrentSatchelPanel;
        private System.Windows.Forms.Label CurrentSatchelLabel;
        private System.Windows.Forms.Label SatchelWeightLabel;
        private System.Windows.Forms.FlowLayoutPanel EssencePanel;
        private System.Windows.Forms.FlowLayoutPanel CatalystPanel;
        private System.Windows.Forms.Label essenceLabel;
        private System.Windows.Forms.Label catalystLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.ComboBox SamplePlayerList;
        private System.Windows.Forms.FlowLayoutPanel ConsumablePanel;
        private System.Windows.Forms.Label consumableLabel;
        private System.Windows.Forms.FlowLayoutPanel PassivePanel;
        private System.Windows.Forms.Label passiveLabel;
    }
}