namespace CosmageV2.GUI
{
    partial class GUIForm
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
            this.AddBasicIngredientButton = new System.Windows.Forms.Button();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.AddAttackCrystalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBasicIngredientButton
            // 
            this.AddBasicIngredientButton.Location = new System.Drawing.Point(323, 511);
            this.AddBasicIngredientButton.Name = "AddBasicIngredientButton";
            this.AddBasicIngredientButton.Size = new System.Drawing.Size(187, 77);
            this.AddBasicIngredientButton.TabIndex = 0;
            this.AddBasicIngredientButton.Text = "AddBasicIngredient";
            this.AddBasicIngredientButton.UseVisualStyleBackColor = true;
            this.AddBasicIngredientButton.Click += new System.EventHandler(this.AddBasicIngredient_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(562, 153);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(119, 50);
            this.StartGameButton.TabIndex = 1;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // AddAttackCrystalButton
            // 
            this.AddAttackCrystalButton.Location = new System.Drawing.Point(736, 511);
            this.AddAttackCrystalButton.Name = "AddAttackCrystalButton";
            this.AddAttackCrystalButton.Size = new System.Drawing.Size(187, 77);
            this.AddAttackCrystalButton.TabIndex = 2;
            this.AddAttackCrystalButton.Text = "AddAttackCrystal";
            this.AddAttackCrystalButton.UseVisualStyleBackColor = true;
            this.AddAttackCrystalButton.Click += new System.EventHandler(this.AddAttackCrystal_Click);
            // 
            // GUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 698);
            this.Controls.Add(this.AddAttackCrystalButton);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.AddBasicIngredientButton);
            this.Name = "GUIForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBasicIngredientButton;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button AddAttackCrystalButton;
    }
}