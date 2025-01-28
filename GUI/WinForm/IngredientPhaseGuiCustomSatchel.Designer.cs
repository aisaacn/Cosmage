namespace CosmageV2.GUI
{
    partial class IngredientPhaseGuiCustomSatchel
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
            EssencePanel = new System.Windows.Forms.FlowLayoutPanel();
            CatalystPanel = new System.Windows.Forms.FlowLayoutPanel();
            NoneButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // EssencePanel
            // 
            EssencePanel.Location = new System.Drawing.Point(13, 15);
            EssencePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            EssencePanel.Name = "EssencePanel";
            EssencePanel.Size = new System.Drawing.Size(1149, 235);
            EssencePanel.TabIndex = 0;
            // 
            // CatalystPanel
            // 
            CatalystPanel.Location = new System.Drawing.Point(14, 259);
            CatalystPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            CatalystPanel.Name = "CatalystPanel";
            CatalystPanel.Size = new System.Drawing.Size(1148, 134);
            CatalystPanel.TabIndex = 1;
            // 
            // NoneButton
            // 
            NoneButton.Location = new System.Drawing.Point(498, 485);
            NoneButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            NoneButton.Name = "NoneButton";
            NoneButton.Size = new System.Drawing.Size(183, 68);
            NoneButton.TabIndex = 2;
            NoneButton.Text = "Add Nothing";
            NoneButton.UseVisualStyleBackColor = true;
            NoneButton.Click += None_Click;
            // 
            // IngredientPhaseGuiCustomSatchel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1176, 605);
            Controls.Add(NoneButton);
            Controls.Add(CatalystPanel);
            Controls.Add(EssencePanel);
            Location = new System.Drawing.Point(0, 369);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "IngredientPhaseGuiCustomSatchel";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "IngredientPhaseGuiCustomSatchel";
            ResumeLayout(false);
        }

        private void NoneButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel EssencePanel;
        private System.Windows.Forms.FlowLayoutPanel CatalystPanel;
        private System.Windows.Forms.Button NoneButton;
    }
}