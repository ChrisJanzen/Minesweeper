namespace Minesweeper
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.MainMenu = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.EndScreenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(116, 150);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(100, 41);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.TabStop = false;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(222, 151);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(98, 40);
            this.Exit.TabIndex = 3;
            this.Exit.TabStop = false;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(12, 150);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(98, 41);
            this.New.TabIndex = 4;
            this.New.TabStop = false;
            this.New.Text = "New Game";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // EndScreenLabel
            // 
            this.EndScreenLabel.AutoSize = true;
            this.EndScreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndScreenLabel.Location = new System.Drawing.Point(88, 63);
            this.EndScreenLabel.Name = "EndScreenLabel";
            this.EndScreenLabel.Size = new System.Drawing.Size(0, 32);
            this.EndScreenLabel.TabIndex = 5;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(332, 203);
            this.ControlBox = false;
            this.Controls.Add(this.EndScreenLabel);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = Minesweeper.Properties.Resources.MineIcon;
            this.MaximizeBox = false;
            this.Name = "GameOver";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameOver_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Label EndScreenLabel;
    }
}