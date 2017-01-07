namespace Minesweeper
{
    partial class GameBoard
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
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvisButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.MineCounter = new System.Windows.Forms.Label();
            this.GameBoardMenu = new System.Windows.Forms.MenuStrip();
            this.GameBoardMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.mainMenuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x9ToolStripMenuItem,
            this.x16ToolStripMenuItem,
            this.x30ToolStripMenuItem});
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.restartToolStripMenuItem.Text = "New Game";
            // 
            // x9ToolStripMenuItem
            // 
            this.x9ToolStripMenuItem.Name = "x9ToolStripMenuItem";
            this.x9ToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.x9ToolStripMenuItem.Text = "9x9";
            this.x9ToolStripMenuItem.Click += new System.EventHandler(this.x9ToolStripMenuItem_Click);
            // 
            // x16ToolStripMenuItem
            // 
            this.x16ToolStripMenuItem.Name = "x16ToolStripMenuItem";
            this.x16ToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.x16ToolStripMenuItem.Text = "16x16";
            this.x16ToolStripMenuItem.Click += new System.EventHandler(this.x16ToolStripMenuItem_Click);
            // 
            // x30ToolStripMenuItem
            // 
            this.x30ToolStripMenuItem.Name = "x30ToolStripMenuItem";
            this.x30ToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.x30ToolStripMenuItem.Text = "30x16";
            this.x30ToolStripMenuItem.Click += new System.EventHandler(this.x30ToolStripMenuItem_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.MainMenuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.exitToolStripMenuItem.Text = "Quit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // InvisButton
            // 
            this.InvisButton.Location = new System.Drawing.Point(12, 831);
            this.InvisButton.Name = "InvisButton";
            this.InvisButton.Size = new System.Drawing.Size(11, 10);
            this.InvisButton.TabIndex = 1;
            this.InvisButton.Text = "button1";
            this.InvisButton.UseVisualStyleBackColor = true;
            this.InvisButton.Visible = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(166, 59);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(87, 32);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "00:00";
            // 
            // MineCounter
            // 
            this.MineCounter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MineCounter.AutoSize = true;
            this.MineCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MineCounter.Location = new System.Drawing.Point(315, 59);
            this.MineCounter.Name = "MineCounter";
            this.MineCounter.Size = new System.Drawing.Size(47, 32);
            this.MineCounter.TabIndex = 5;
            this.MineCounter.Text = "99";
            // 
            // GameBoardMenu
            // 
            this.GameBoardMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.GameBoardMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.GameBoardMenu.Location = new System.Drawing.Point(0, 0);
            this.GameBoardMenu.Name = "GameBoardMenu";
            this.GameBoardMenu.Size = new System.Drawing.Size(477, 28);
            this.GameBoardMenu.TabIndex = 0;
            this.GameBoardMenu.Text = "menuStrip1";
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(477, 356);
            this.Controls.Add(this.MineCounter);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.InvisButton);
            this.Controls.Add(this.GameBoardMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Minesweeper.Properties.Resources.MineIcon;
            this.MainMenuStrip = this.GameBoardMenu;
            this.Name = "GameBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameBoard_FormClosing);
            this.GameBoardMenu.ResumeLayout(false);
            this.GameBoardMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x16ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button InvisButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label MineCounter;
        private System.Windows.Forms.MenuStrip GameBoardMenu;
    }
}