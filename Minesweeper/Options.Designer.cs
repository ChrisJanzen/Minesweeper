namespace Minesweeper
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReturnButton = new System.Windows.Forms.Button();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.clearRecords = new System.Windows.Forms.Button();
            this.toggleSound = new System.Windows.Forms.Button();
            this.InvisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(92, 362);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(228, 49);
            this.ReturnButton.TabIndex = 30;
            this.ReturnButton.TabStop = false;
            this.ReturnButton.Text = "Main Menu";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsLabel.Location = new System.Drawing.Point(147, 54);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(118, 36);
            this.OptionsLabel.TabIndex = 33;
            this.OptionsLabel.Text = "Options";
            // 
            // clearRecords
            // 
            this.clearRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearRecords.Location = new System.Drawing.Point(92, 227);
            this.clearRecords.Name = "clearRecords";
            this.clearRecords.Size = new System.Drawing.Size(228, 49);
            this.clearRecords.TabIndex = 34;
            this.clearRecords.Text = "Reset Records";
            this.clearRecords.UseVisualStyleBackColor = true;
            this.clearRecords.Click += new System.EventHandler(this.clearRecords_Click);
            // 
            // toggleSound
            // 
            this.toggleSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSound.Location = new System.Drawing.Point(92, 157);
            this.toggleSound.Name = "toggleSound";
            this.toggleSound.Size = new System.Drawing.Size(228, 49);
            this.toggleSound.TabIndex = 35;
            this.toggleSound.UseVisualStyleBackColor = true;
            this.toggleSound.Click += new System.EventHandler(this.toggleSound_Click);
            // 
            // InvisButton
            // 
            this.InvisButton.Location = new System.Drawing.Point(13, 476);
            this.InvisButton.Name = "InvisButton";
            this.InvisButton.Size = new System.Drawing.Size(10, 10);
            this.InvisButton.TabIndex = 36;
            this.InvisButton.UseVisualStyleBackColor = true;
            this.InvisButton.Visible = false;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(410, 498);
            this.Controls.Add(this.InvisButton);
            this.Controls.Add(this.toggleSound);
            this.Controls.Add(this.clearRecords);
            this.Controls.Add(this.OptionsLabel);
            this.Controls.Add(this.ReturnButton);
            this.Icon = global::Minesweeper.Properties.Resources.MineIcon;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label OptionsLabel;
        private System.Windows.Forms.Button clearRecords;
        private System.Windows.Forms.Button toggleSound;
        private System.Windows.Forms.Button InvisButton;
    }
}