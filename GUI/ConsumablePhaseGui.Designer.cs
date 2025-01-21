namespace CosmageV2.GUI
{
    partial class ConsumablePhaseGui
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
            this.ConsumablePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FinishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConsumablePanel
            // 
            this.ConsumablePanel.AutoScroll = true;
            this.ConsumablePanel.Location = new System.Drawing.Point(12, 12);
            this.ConsumablePanel.Name = "ConsumablePanel";
            this.ConsumablePanel.Size = new System.Drawing.Size(776, 318);
            this.ConsumablePanel.TabIndex = 0;
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(339, 336);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(106, 43);
            this.FinishButton.TabIndex = 1;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // ConsumablePhaseGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.ConsumablePanel);
            this.Name = "ConsumablePhaseGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsumablePhaseGui";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ConsumablePanel;
        private System.Windows.Forms.Button FinishButton;
    }
}