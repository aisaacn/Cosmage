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
            this.EssencePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CatalystPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NoneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EssencePanel
            // 
            this.EssencePanel.Location = new System.Drawing.Point(12, 12);
            this.EssencePanel.Name = "EssencePanel";
            this.EssencePanel.Size = new System.Drawing.Size(1034, 188);
            this.EssencePanel.TabIndex = 0;
            // 
            // CatalystPanel
            // 
            this.CatalystPanel.Location = new System.Drawing.Point(13, 207);
            this.CatalystPanel.Name = "CatalystPanel";
            this.CatalystPanel.Size = new System.Drawing.Size(1033, 107);
            this.CatalystPanel.TabIndex = 1;
            // 
            // NoneButton
            // 
            this.NoneButton.Location = new System.Drawing.Point(448, 388);
            this.NoneButton.Name = "NoneButton";
            this.NoneButton.Size = new System.Drawing.Size(165, 54);
            this.NoneButton.TabIndex = 2;
            this.NoneButton.Text = "Add Nothing";
            this.NoneButton.UseVisualStyleBackColor = true;
            this.NoneButton.Click += new System.EventHandler(this.None_Click);
            // 
            // IngredientPhaseGuiCustomSatchel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 484);
            this.Controls.Add(this.NoneButton);
            this.Controls.Add(this.CatalystPanel);
            this.Controls.Add(this.EssencePanel);
            this.Name = "IngredientPhaseGuiCustomSatchel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngredientPhaseGuiCustomSatchel";
            this.ResumeLayout(false);

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