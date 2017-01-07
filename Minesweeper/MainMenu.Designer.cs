namespace Minesweeper
{
    partial class MainMenu
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
            this.Records = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Options = new System.Windows.Forms.Button();
            this.InvisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Records
            // 
            this.Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Records.Location = new System.Drawing.Point(92, 286);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(226, 61);
            this.Records.TabIndex = 2;
            this.Records.TabStop = false;
            this.Records.Text = "Records";
            this.Records.UseVisualStyleBackColor = true;
            this.Records.Click += new System.EventHandler(this.Records_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(92, 420);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(226, 61);
            this.Exit.TabIndex = 3;
            this.Exit.TabStop = false;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // NewGame
            // 
            this.NewGame.AutoSize = true;
            this.NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.Location = new System.Drawing.Point(92, 219);
            this.NewGame.Name = "NewGame";
            this.NewGame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewGame.Size = new System.Drawing.Size(226, 61);
            this.NewGame.TabIndex = 1;
            this.NewGame.TabStop = false;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(67, 87);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(279, 51);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Minesweeper";
            // 
            // Options
            // 
            this.Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.Location = new System.Drawing.Point(92, 353);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(226, 61);
            this.Options.TabIndex = 5;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = true;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // InvisButton
            // 
            this.InvisButton.Location = new System.Drawing.Point(13, 476);
            this.InvisButton.Name = "InvisButton";
            this.InvisButton.Size = new System.Drawing.Size(10, 10);
            this.InvisButton.TabIndex = 6;
            this.InvisButton.Text = "button1";
            this.InvisButton.UseVisualStyleBackColor = true;
            this.InvisButton.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(410, 498);
            this.Controls.Add(this.InvisButton);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Records);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Minesweeper.Properties.Resources.MineIcon;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Records;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Button InvisButton;
    }
}

