namespace CosmageV2.GUI
{
    partial class StartScreenGui
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
            this.button1 = new System.Windows.Forms.Button();
            this.CreatePlayer1Button = new System.Windows.Forms.Button();
            this.CreatePlayer2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // CreatePlayer1Button
            // 
            this.CreatePlayer1Button.Location = new System.Drawing.Point(117, 72);
            this.CreatePlayer1Button.Name = "CreatePlayer1Button";
            this.CreatePlayer1Button.Size = new System.Drawing.Size(161, 64);
            this.CreatePlayer1Button.TabIndex = 1;
            this.CreatePlayer1Button.Text = "Modify Player 1 init";
            this.CreatePlayer1Button.UseVisualStyleBackColor = true;
            this.CreatePlayer1Button.Click += new System.EventHandler(this.CreatePlayer1Button_Click);
            // 
            // CreatePlayer2Button
            // 
            this.CreatePlayer2Button.Location = new System.Drawing.Point(517, 72);
            this.CreatePlayer2Button.Name = "CreatePlayer2Button";
            this.CreatePlayer2Button.Size = new System.Drawing.Size(161, 64);
            this.CreatePlayer2Button.TabIndex = 2;
            this.CreatePlayer2Button.Text = "Modify Player 2 init";
            this.CreatePlayer2Button.UseVisualStyleBackColor = true;
            this.CreatePlayer2Button.Click += new System.EventHandler(this.CreatePlayer2Button_Click);
            // 
            // StartScreenGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreatePlayer2Button);
            this.Controls.Add(this.CreatePlayer1Button);
            this.Controls.Add(this.button1);
            this.Name = "StartScreenGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartScreenGui";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CreatePlayer1Button;
        private System.Windows.Forms.Button CreatePlayer2Button;
    }
}