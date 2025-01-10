namespace CosmageV2.GUI
{
    partial class GameBoardGui
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
            this.Player2CauldronLabel = new System.Windows.Forms.Label();
            this.Player1CauldronLabel = new System.Windows.Forms.Label();
            this.Player2CauldronContents = new System.Windows.Forms.Label();
            this.Player1CauldronContents = new System.Windows.Forms.Label();
            this.Player2Catalyst = new System.Windows.Forms.Label();
            this.Player1Catalyst = new System.Windows.Forms.Label();
            this.CurrentPlayerLabel = new System.Windows.Forms.Label();
            this.Player2RuneNames = new System.Windows.Forms.Label();
            this.Player2RuneStatus = new System.Windows.Forms.Label();
            this.Player1RuneNames = new System.Windows.Forms.Label();
            this.Player1RuneStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Player2CauldronLabel
            // 
            this.Player2CauldronLabel.AutoSize = true;
            this.Player2CauldronLabel.Location = new System.Drawing.Point(55, 32);
            this.Player2CauldronLabel.Name = "Player2CauldronLabel";
            this.Player2CauldronLabel.Size = new System.Drawing.Size(164, 20);
            this.Player2CauldronLabel.TabIndex = 0;
            this.Player2CauldronLabel.Text = "Player2CauldronLabel";
            // 
            // Player1CauldronLabel
            // 
            this.Player1CauldronLabel.AutoSize = true;
            this.Player1CauldronLabel.Location = new System.Drawing.Point(55, 326);
            this.Player1CauldronLabel.Name = "Player1CauldronLabel";
            this.Player1CauldronLabel.Size = new System.Drawing.Size(164, 20);
            this.Player1CauldronLabel.TabIndex = 1;
            this.Player1CauldronLabel.Text = "Player1CauldronLabel";
            // 
            // Player2CauldronContents
            // 
            this.Player2CauldronContents.AutoSize = true;
            this.Player2CauldronContents.Location = new System.Drawing.Point(71, 52);
            this.Player2CauldronContents.Name = "Player2CauldronContents";
            this.Player2CauldronContents.Size = new System.Drawing.Size(190, 20);
            this.Player2CauldronContents.TabIndex = 2;
            this.Player2CauldronContents.Text = "Player2CauldronContents";
            // 
            // Player1CauldronContents
            // 
            this.Player1CauldronContents.AutoSize = true;
            this.Player1CauldronContents.Location = new System.Drawing.Point(71, 346);
            this.Player1CauldronContents.Name = "Player1CauldronContents";
            this.Player1CauldronContents.Size = new System.Drawing.Size(182, 20);
            this.Player1CauldronContents.TabIndex = 3;
            this.Player1CauldronContents.Text = "Player1CauldronContent";
            // 
            // Player2Catalyst
            // 
            this.Player2Catalyst.AutoSize = true;
            this.Player2Catalyst.Location = new System.Drawing.Point(71, 72);
            this.Player2Catalyst.Name = "Player2Catalyst";
            this.Player2Catalyst.Size = new System.Drawing.Size(118, 20);
            this.Player2Catalyst.TabIndex = 4;
            this.Player2Catalyst.Text = "Player2Catalyst";
            // 
            // Player1Catalyst
            // 
            this.Player1Catalyst.AutoSize = true;
            this.Player1Catalyst.Location = new System.Drawing.Point(71, 366);
            this.Player1Catalyst.Name = "Player1Catalyst";
            this.Player1Catalyst.Size = new System.Drawing.Size(118, 20);
            this.Player1Catalyst.TabIndex = 5;
            this.Player1Catalyst.Text = "Player1Catalyst";
            // 
            // CurrentPlayerLabel
            // 
            this.CurrentPlayerLabel.AutoSize = true;
            this.CurrentPlayerLabel.Location = new System.Drawing.Point(55, 203);
            this.CurrentPlayerLabel.Name = "CurrentPlayerLabel";
            this.CurrentPlayerLabel.Size = new System.Drawing.Size(144, 20);
            this.CurrentPlayerLabel.TabIndex = 6;
            this.CurrentPlayerLabel.Text = "CurrentPlayerLabel";
            // 
            // Player2RuneNames
            // 
            this.Player2RuneNames.AutoSize = true;
            this.Player2RuneNames.Location = new System.Drawing.Point(446, 52);
            this.Player2RuneNames.Name = "Player2RuneNames";
            this.Player2RuneNames.Size = new System.Drawing.Size(150, 20);
            this.Player2RuneNames.TabIndex = 7;
            this.Player2RuneNames.Text = "Player2RuneNames";
            // 
            // Player2RuneStatus
            // 
            this.Player2RuneStatus.AutoSize = true;
            this.Player2RuneStatus.Location = new System.Drawing.Point(591, 52);
            this.Player2RuneStatus.Name = "Player2RuneStatus";
            this.Player2RuneStatus.Size = new System.Drawing.Size(147, 20);
            this.Player2RuneStatus.TabIndex = 10;
            this.Player2RuneStatus.Text = "Player2RuneStatus";
            // 
            // Player1RuneNames
            // 
            this.Player1RuneNames.AutoSize = true;
            this.Player1RuneNames.Location = new System.Drawing.Point(446, 346);
            this.Player1RuneNames.Name = "Player1RuneNames";
            this.Player1RuneNames.Size = new System.Drawing.Size(150, 20);
            this.Player1RuneNames.TabIndex = 13;
            this.Player1RuneNames.Text = "Player1RuneNames";
            // 
            // Player1RuneStatus
            // 
            this.Player1RuneStatus.AutoSize = true;
            this.Player1RuneStatus.Location = new System.Drawing.Point(591, 346);
            this.Player1RuneStatus.Name = "Player1RuneStatus";
            this.Player1RuneStatus.Size = new System.Drawing.Size(147, 20);
            this.Player1RuneStatus.TabIndex = 16;
            this.Player1RuneStatus.Text = "Player1RuneStatus";
            // 
            // GameBoardGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Player1RuneStatus);
            this.Controls.Add(this.Player1RuneNames);
            this.Controls.Add(this.Player2RuneStatus);
            this.Controls.Add(this.Player2RuneNames);
            this.Controls.Add(this.CurrentPlayerLabel);
            this.Controls.Add(this.Player1Catalyst);
            this.Controls.Add(this.Player2Catalyst);
            this.Controls.Add(this.Player1CauldronContents);
            this.Controls.Add(this.Player2CauldronContents);
            this.Controls.Add(this.Player1CauldronLabel);
            this.Controls.Add(this.Player2CauldronLabel);
            this.Name = "GameBoardGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GameBoard";
            this.Load += new System.EventHandler(this.GameBoardGui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Player2CauldronLabel;
        private System.Windows.Forms.Label Player1CauldronLabel;
        private System.Windows.Forms.Label Player2CauldronContents;
        private System.Windows.Forms.Label Player1CauldronContents;
        private System.Windows.Forms.Label Player2Catalyst;
        private System.Windows.Forms.Label Player1Catalyst;
        private System.Windows.Forms.Label CurrentPlayerLabel;
        private System.Windows.Forms.Label Player2RuneNames;
        private System.Windows.Forms.Label Player2RuneStatus;
        private System.Windows.Forms.Label Player1RuneNames;
        private System.Windows.Forms.Label Player1RuneStatus;
    }
}