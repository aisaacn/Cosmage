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
            this.SuspendLayout();
            // 
            // Player2CauldronLabel
            // 
            this.Player2CauldronLabel.AutoSize = true;
            this.Player2CauldronLabel.Location = new System.Drawing.Point(55, 32);
            this.Player2CauldronLabel.Name = "Player2CauldronLabel";
            this.Player2CauldronLabel.Size = new System.Drawing.Size(29, 20);
            this.Player2CauldronLabel.TabIndex = 0;
            this.Player2CauldronLabel.Text = "init";
            //this.Player2CauldronLabel.Click += new System.EventHandler(this.Player2CauldronLabel_Click);
            // 
            // Player1CauldronLabel
            // 
            this.Player1CauldronLabel.AutoSize = true;
            this.Player1CauldronLabel.Location = new System.Drawing.Point(55, 326);
            this.Player1CauldronLabel.Name = "Player1CauldronLabel";
            this.Player1CauldronLabel.Size = new System.Drawing.Size(29, 20);
            this.Player1CauldronLabel.TabIndex = 1;
            this.Player1CauldronLabel.Text = "init";
            // 
            // Player2CauldronContents
            // 
            this.Player2CauldronContents.AutoSize = true;
            this.Player2CauldronContents.Location = new System.Drawing.Point(194, 52);
            this.Player2CauldronContents.Name = "Player2CauldronContents";
            this.Player2CauldronContents.Size = new System.Drawing.Size(29, 20);
            this.Player2CauldronContents.TabIndex = 2;
            this.Player2CauldronContents.Text = "init";
            // 
            // Player1CauldronContents
            // 
            this.Player1CauldronContents.AutoSize = true;
            this.Player1CauldronContents.Location = new System.Drawing.Point(194, 349);
            this.Player1CauldronContents.Name = "Player1CauldronContents";
            this.Player1CauldronContents.Size = new System.Drawing.Size(29, 20);
            this.Player1CauldronContents.TabIndex = 3;
            this.Player1CauldronContents.Text = "init";
            // 
            // Player2Catalyst
            // 
            this.Player2Catalyst.AutoSize = true;
            this.Player2Catalyst.Location = new System.Drawing.Point(194, 72);
            this.Player2Catalyst.Name = "Player2Catalyst";
            this.Player2Catalyst.Size = new System.Drawing.Size(29, 20);
            this.Player2Catalyst.TabIndex = 4;
            this.Player2Catalyst.Text = "init";
            // 
            // Player1Catalyst
            // 
            this.Player1Catalyst.AutoSize = true;
            this.Player1Catalyst.Location = new System.Drawing.Point(194, 369);
            this.Player1Catalyst.Name = "Player1Catalyst";
            this.Player1Catalyst.Size = new System.Drawing.Size(29, 20);
            this.Player1Catalyst.TabIndex = 5;
            this.Player1Catalyst.Text = "init";
            // 
            // CurrentPlayerLabel
            // 
            this.CurrentPlayerLabel.AutoSize = true;
            this.CurrentPlayerLabel.Location = new System.Drawing.Point(55, 203);
            this.CurrentPlayerLabel.Name = "CurrentPlayerLabel";
            this.CurrentPlayerLabel.Size = new System.Drawing.Size(29, 20);
            this.CurrentPlayerLabel.TabIndex = 6;
            this.CurrentPlayerLabel.Text = "init";
            // 
            // GameBoardGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CurrentPlayerLabel);
            this.Controls.Add(this.Player1Catalyst);
            this.Controls.Add(this.Player2Catalyst);
            this.Controls.Add(this.Player1CauldronContents);
            this.Controls.Add(this.Player2CauldronContents);
            this.Controls.Add(this.Player1CauldronLabel);
            this.Controls.Add(this.Player2CauldronLabel);
            this.Name = "GameBoardGui";
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
    }
}