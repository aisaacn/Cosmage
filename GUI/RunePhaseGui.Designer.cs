namespace CosmageV2.GUI
{
    partial class RunePhaseGui
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
            this.ChargeRune1Button = new System.Windows.Forms.Button();
            this.ChargeRune2Button = new System.Windows.Forms.Button();
            this.ChargeRune3Button = new System.Windows.Forms.Button();
            this.ChargeAndActivateButton = new System.Windows.Forms.Button();
            this.ChargeButton = new System.Windows.Forms.Button();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChargeRune1Button
            // 
            this.ChargeRune1Button.Location = new System.Drawing.Point(62, 149);
            this.ChargeRune1Button.Name = "ChargeRune1Button";
            this.ChargeRune1Button.Size = new System.Drawing.Size(175, 49);
            this.ChargeRune1Button.TabIndex = 0;
            this.ChargeRune1Button.Text = "Charge Rune1";
            this.ChargeRune1Button.UseVisualStyleBackColor = true;
            this.ChargeRune1Button.Click += new System.EventHandler(this.ChargeRune1Button_Click);
            // 
            // ChargeRune2Button
            // 
            this.ChargeRune2Button.Location = new System.Drawing.Point(312, 149);
            this.ChargeRune2Button.Name = "ChargeRune2Button";
            this.ChargeRune2Button.Size = new System.Drawing.Size(175, 49);
            this.ChargeRune2Button.TabIndex = 1;
            this.ChargeRune2Button.Text = "Charge Rune2";
            this.ChargeRune2Button.UseVisualStyleBackColor = true;
            this.ChargeRune2Button.Click += new System.EventHandler(this.ChargeRune2Button_Click);
            // 
            // ChargeRune3Button
            // 
            this.ChargeRune3Button.Location = new System.Drawing.Point(566, 149);
            this.ChargeRune3Button.Name = "ChargeRune3Button";
            this.ChargeRune3Button.Size = new System.Drawing.Size(175, 49);
            this.ChargeRune3Button.TabIndex = 2;
            this.ChargeRune3Button.Text = "Charge Rune3";
            this.ChargeRune3Button.UseVisualStyleBackColor = true;
            this.ChargeRune3Button.Click += new System.EventHandler(this.ChargeRune3Button_Click);
            // 
            // ChargeAndActivateButton
            // 
            this.ChargeAndActivateButton.Location = new System.Drawing.Point(185, 307);
            this.ChargeAndActivateButton.Name = "ChargeAndActivateButton";
            this.ChargeAndActivateButton.Size = new System.Drawing.Size(175, 49);
            this.ChargeAndActivateButton.TabIndex = 3;
            this.ChargeAndActivateButton.Text = "Charge and Activate";
            this.ChargeAndActivateButton.UseVisualStyleBackColor = true;
            this.ChargeAndActivateButton.Click += new System.EventHandler(this.ChargeAndActivateButton_Click);
            // 
            // ChargeButton
            // 
            this.ChargeButton.Location = new System.Drawing.Point(443, 307);
            this.ChargeButton.Name = "ChargeButton";
            this.ChargeButton.Size = new System.Drawing.Size(175, 49);
            this.ChargeButton.TabIndex = 4;
            this.ChargeButton.Text = "Charge";
            this.ChargeButton.UseVisualStyleBackColor = true;
            this.ChargeButton.Click += new System.EventHandler(this.ChargeButton_Click);
            // 
            // RunePhaseGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChargeButton);
            this.Controls.Add(this.ChargeAndActivateButton);
            this.Controls.Add(this.ChargeRune3Button);
            this.Controls.Add(this.ChargeRune2Button);
            this.Controls.Add(this.ChargeRune1Button);
            this.Name = "RunePhaseGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunePhaseGui";
            this.Load += new System.EventHandler(this.RunePhaseGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChargeRune1Button;
        private System.Windows.Forms.Button ChargeRune2Button;
        private System.Windows.Forms.Button ChargeRune3Button;
        private System.Windows.Forms.Button ChargeAndActivateButton;
        private System.Windows.Forms.Button ChargeButton;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}