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
            ElementBox = new System.Windows.Forms.GroupBox();
            UnnaturalButton = new System.Windows.Forms.RadioButton();
            MechanicalButton = new System.Windows.Forms.RadioButton();
            NaturalButton = new System.Windows.Forms.RadioButton();
            PlayerName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            CurrentSatchelPanel = new System.Windows.Forms.FlowLayoutPanel();
            CurrentSatchelLabel = new System.Windows.Forms.Label();
            SatchelWeightLabel = new System.Windows.Forms.Label();
            EssencePanel = new System.Windows.Forms.FlowLayoutPanel();
            CatalystPanel = new System.Windows.Forms.FlowLayoutPanel();
            essenceLabel = new System.Windows.Forms.Label();
            catalystLabel = new System.Windows.Forms.Label();
            ConfirmButton = new System.Windows.Forms.Button();
            SamplePlayerList = new System.Windows.Forms.ComboBox();
            ConsumablePanel = new System.Windows.Forms.FlowLayoutPanel();
            consumableLabel = new System.Windows.Forms.Label();
            PassivePanel = new System.Windows.Forms.FlowLayoutPanel();
            passiveLabel = new System.Windows.Forms.Label();
            ElementBox.SuspendLayout();
            SuspendLayout();
            // 
            // ElementBox
            // 
            ElementBox.Controls.Add(UnnaturalButton);
            ElementBox.Controls.Add(MechanicalButton);
            ElementBox.Controls.Add(NaturalButton);
            ElementBox.Location = new System.Drawing.Point(13, 15);
            ElementBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ElementBox.Name = "ElementBox";
            ElementBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ElementBox.Size = new System.Drawing.Size(450, 99);
            ElementBox.TabIndex = 0;
            ElementBox.TabStop = false;
            ElementBox.Text = "Select Player Element:";
            // 
            // UnnaturalButton
            // 
            UnnaturalButton.AutoSize = true;
            UnnaturalButton.Location = new System.Drawing.Point(308, 42);
            UnnaturalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            UnnaturalButton.Name = "UnnaturalButton";
            UnnaturalButton.Size = new System.Drawing.Size(113, 29);
            UnnaturalButton.TabIndex = 2;
            UnnaturalButton.TabStop = true;
            UnnaturalButton.Text = "Unnatural";
            UnnaturalButton.UseVisualStyleBackColor = true;
            // 
            // MechanicalButton
            // 
            MechanicalButton.AutoSize = true;
            MechanicalButton.Location = new System.Drawing.Point(148, 42);
            MechanicalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MechanicalButton.Name = "MechanicalButton";
            MechanicalButton.Size = new System.Drawing.Size(124, 29);
            MechanicalButton.TabIndex = 1;
            MechanicalButton.TabStop = true;
            MechanicalButton.Text = "Mechanical";
            MechanicalButton.UseVisualStyleBackColor = true;
            // 
            // NaturalButton
            // 
            NaturalButton.AutoSize = true;
            NaturalButton.Location = new System.Drawing.Point(21, 42);
            NaturalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            NaturalButton.Name = "NaturalButton";
            NaturalButton.Size = new System.Drawing.Size(94, 29);
            NaturalButton.TabIndex = 0;
            NaturalButton.TabStop = true;
            NaturalButton.Text = "Natural";
            NaturalButton.UseVisualStyleBackColor = true;
            // 
            // PlayerName
            // 
            PlayerName.Location = new System.Drawing.Point(506, 55);
            PlayerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PlayerName.Name = "PlayerName";
            PlayerName.Size = new System.Drawing.Size(370, 31);
            PlayerName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(501, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 25);
            label1.TabIndex = 2;
            label1.Text = "Enter Player Name:";
            // 
            // CurrentSatchelPanel
            // 
            CurrentSatchelPanel.AutoScroll = true;
            CurrentSatchelPanel.Location = new System.Drawing.Point(13, 449);
            CurrentSatchelPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            CurrentSatchelPanel.Name = "CurrentSatchelPanel";
            CurrentSatchelPanel.Size = new System.Drawing.Size(1149, 315);
            CurrentSatchelPanel.TabIndex = 4;
            // 
            // CurrentSatchelLabel
            // 
            CurrentSatchelLabel.AutoSize = true;
            CurrentSatchelLabel.Location = new System.Drawing.Point(9, 420);
            CurrentSatchelLabel.Name = "CurrentSatchelLabel";
            CurrentSatchelLabel.Size = new System.Drawing.Size(196, 25);
            CurrentSatchelLabel.TabIndex = 0;
            CurrentSatchelLabel.Text = "Current Satchel Weight:";
            // 
            // SatchelWeightLabel
            // 
            SatchelWeightLabel.AutoSize = true;
            SatchelWeightLabel.Location = new System.Drawing.Point(213, 420);
            SatchelWeightLabel.Name = "SatchelWeightLabel";
            SatchelWeightLabel.Size = new System.Drawing.Size(0, 25);
            SatchelWeightLabel.TabIndex = 5;
            // 
            // EssencePanel
            // 
            EssencePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            EssencePanel.Location = new System.Drawing.Point(13, 144);
            EssencePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            EssencePanel.Name = "EssencePanel";
            EssencePanel.Size = new System.Drawing.Size(429, 272);
            EssencePanel.TabIndex = 6;
            // 
            // CatalystPanel
            // 
            CatalystPanel.AutoScroll = true;
            CatalystPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            CatalystPanel.Location = new System.Drawing.Point(449, 144);
            CatalystPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            CatalystPanel.Name = "CatalystPanel";
            CatalystPanel.Size = new System.Drawing.Size(222, 272);
            CatalystPanel.TabIndex = 7;
            CatalystPanel.WrapContents = false;
            // 
            // essenceLabel
            // 
            essenceLabel.AutoSize = true;
            essenceLabel.Location = new System.Drawing.Point(13, 115);
            essenceLabel.Name = "essenceLabel";
            essenceLabel.Size = new System.Drawing.Size(136, 25);
            essenceLabel.TabIndex = 8;
            essenceLabel.Text = "Select Essences:";
            // 
            // catalystLabel
            // 
            catalystLabel.AutoSize = true;
            catalystLabel.Location = new System.Drawing.Point(444, 115);
            catalystLabel.Name = "catalystLabel";
            catalystLabel.Size = new System.Drawing.Size(137, 25);
            catalystLabel.TabIndex = 9;
            catalystLabel.Text = "Select Catalysts:";
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new System.Drawing.Point(816, 771);
            ConfirmButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new System.Drawing.Size(194, 44);
            ConfirmButton.TabIndex = 10;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // SamplePlayerList
            // 
            SamplePlayerList.FormattingEnabled = true;
            SamplePlayerList.Location = new System.Drawing.Point(112, 780);
            SamplePlayerList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SamplePlayerList.Name = "SamplePlayerList";
            SamplePlayerList.Size = new System.Drawing.Size(284, 33);
            SamplePlayerList.TabIndex = 11;
            SamplePlayerList.Text = "Choose Sample Player...";
            SamplePlayerList.SelectedIndexChanged += SamplePlayer_Select;
            // 
            // ConsumablePanel
            // 
            ConsumablePanel.AutoScroll = true;
            ConsumablePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            ConsumablePanel.Location = new System.Drawing.Point(674, 144);
            ConsumablePanel.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            ConsumablePanel.Name = "ConsumablePanel";
            ConsumablePanel.Size = new System.Drawing.Size(244, 272);
            ConsumablePanel.TabIndex = 8;
            ConsumablePanel.WrapContents = false;
            // 
            // consumableLabel
            // 
            consumableLabel.AutoSize = true;
            consumableLabel.Location = new System.Drawing.Point(670, 115);
            consumableLabel.Name = "consumableLabel";
            consumableLabel.Size = new System.Drawing.Size(174, 25);
            consumableLabel.TabIndex = 12;
            consumableLabel.Text = "Select Consumables:";
            // 
            // PassivePanel
            // 
            PassivePanel.AutoScroll = true;
            PassivePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            PassivePanel.Location = new System.Drawing.Point(922, 144);
            PassivePanel.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            PassivePanel.Name = "PassivePanel";
            PassivePanel.Size = new System.Drawing.Size(244, 272);
            PassivePanel.TabIndex = 9;
            PassivePanel.WrapContents = false;
            // 
            // passiveLabel
            // 
            passiveLabel.AutoSize = true;
            passiveLabel.Location = new System.Drawing.Point(918, 115);
            passiveLabel.Name = "passiveLabel";
            passiveLabel.Size = new System.Drawing.Size(172, 25);
            passiveLabel.TabIndex = 13;
            passiveLabel.Text = "Select Passive Items:";
            // 
            // PlayerCreatorGui
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1176, 830);
            Controls.Add(passiveLabel);
            Controls.Add(PassivePanel);
            Controls.Add(consumableLabel);
            Controls.Add(ConsumablePanel);
            Controls.Add(SamplePlayerList);
            Controls.Add(ConfirmButton);
            Controls.Add(catalystLabel);
            Controls.Add(essenceLabel);
            Controls.Add(CatalystPanel);
            Controls.Add(EssencePanel);
            Controls.Add(SatchelWeightLabel);
            Controls.Add(CurrentSatchelLabel);
            Controls.Add(CurrentSatchelPanel);
            Controls.Add(label1);
            Controls.Add(PlayerName);
            Controls.Add(ElementBox);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "PlayerCreatorGui";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PlayerCreatorGui";
            ElementBox.ResumeLayout(false);
            ElementBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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