namespace CosmageV2.GUI
{
    partial class ChooseAttackTargetGui
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
            ConstructsPanel = new System.Windows.Forms.FlowLayoutPanel();
            AttackOtherPlayerButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ConstructsPanel
            // 
            ConstructsPanel.AutoScroll = true;
            ConstructsPanel.Location = new System.Drawing.Point(12, 131);
            ConstructsPanel.Name = "ConstructsPanel";
            ConstructsPanel.Size = new System.Drawing.Size(776, 307);
            ConstructsPanel.TabIndex = 0;
            // 
            // AttackOtherPlayerButton
            // 
            AttackOtherPlayerButton.AutoSize = true;
            AttackOtherPlayerButton.Location = new System.Drawing.Point(300, 52);
            AttackOtherPlayerButton.Name = "AttackOtherPlayerButton";
            AttackOtherPlayerButton.Size = new System.Drawing.Size(185, 51);
            AttackOtherPlayerButton.TabIndex = 1;
            AttackOtherPlayerButton.Text = "otherPlayerInit";
            AttackOtherPlayerButton.UseVisualStyleBackColor = true;
            AttackOtherPlayerButton.Click += AttackOtherPlayerButton_Click;
            // 
            // ChooseAttackTargetGui
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(AttackOtherPlayerButton);
            Controls.Add(ConstructsPanel);
            Location = new System.Drawing.Point(0, 369);
            Name = "ChooseAttackTargetGui";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "ChooseAttackTargetGui";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ConstructsPanel;
        private System.Windows.Forms.Button AttackOtherPlayerButton;
    }
}