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
            ConsumablePanel = new System.Windows.Forms.FlowLayoutPanel();
            FinishButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ConsumablePanel
            // 
            ConsumablePanel.AutoScroll = true;
            ConsumablePanel.Location = new System.Drawing.Point(13, 15);
            ConsumablePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ConsumablePanel.Name = "ConsumablePanel";
            ConsumablePanel.Size = new System.Drawing.Size(862, 398);
            ConsumablePanel.TabIndex = 0;
            // 
            // FinishButton
            // 
            FinishButton.Location = new System.Drawing.Point(377, 420);
            FinishButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            FinishButton.Name = "FinishButton";
            FinishButton.Size = new System.Drawing.Size(118, 54);
            FinishButton.TabIndex = 1;
            FinishButton.Text = "Finish";
            FinishButton.UseVisualStyleBackColor = true;
            FinishButton.Click += FinishButton_Click;
            // 
            // ConsumablePhaseGui
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(889, 562);
            Controls.Add(FinishButton);
            Controls.Add(ConsumablePanel);
            Location = new System.Drawing.Point(0, 369);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ConsumablePhaseGui";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "ConsumablePhaseGui";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ConsumablePanel;
        private System.Windows.Forms.Button FinishButton;
    }
}