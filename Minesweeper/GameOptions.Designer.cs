namespace Minesweeper
{
    partial class GameOptions
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
            this.MediumBoard = new System.Windows.Forms.Button();
            this.LargeBoard = new System.Windows.Forms.Button();
            this.SmallBoard = new System.Windows.Forms.Button();
            this.InvisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MediumBoard
            // 
            this.MediumBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MediumBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumBoard.Location = new System.Drawing.Point(93, 223);
            this.MediumBoard.Name = "MediumBoard";
            this.MediumBoard.Size = new System.Drawing.Size(226, 61);
            this.MediumBoard.TabIndex = 2;
            this.MediumBoard.TabStop = false;
            this.MediumBoard.Text = "Medium 16x16";
            this.MediumBoard.UseVisualStyleBackColor = true;
            this.MediumBoard.Click += new System.EventHandler(this.MediumBoard_Click);
            // 
            // LargeBoard
            // 
            this.LargeBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LargeBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LargeBoard.Location = new System.Drawing.Point(93, 301);
            this.LargeBoard.Name = "LargeBoard";
            this.LargeBoard.Size = new System.Drawing.Size(226, 61);
            this.LargeBoard.TabIndex = 3;
            this.LargeBoard.TabStop = false;
            this.LargeBoard.Text = "Hard 30x16";
            this.LargeBoard.UseVisualStyleBackColor = true;
            this.LargeBoard.Click += new System.EventHandler(this.LargeBoard_Click);
            // 
            // SmallBoard
            // 
            this.SmallBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SmallBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallBoard.Location = new System.Drawing.Point(93, 144);
            this.SmallBoard.Name = "SmallBoard";
            this.SmallBoard.Size = new System.Drawing.Size(226, 61);
            this.SmallBoard.TabIndex = 1;
            this.SmallBoard.TabStop = false;
            this.SmallBoard.Text = "Easy 9x9";
            this.SmallBoard.UseVisualStyleBackColor = true;
            this.SmallBoard.Click += new System.EventHandler(this.SmallBoard_Click);
            // 
            // InvisButton
            // 
            this.InvisButton.Location = new System.Drawing.Point(12, 476);
            this.InvisButton.Name = "InvisButton";
            this.InvisButton.Size = new System.Drawing.Size(10, 10);
            this.InvisButton.TabIndex = 0;
            this.InvisButton.Text = "button1";
            this.InvisButton.UseVisualStyleBackColor = true;
            this.InvisButton.Visible = false;
            // 
            // GameOptions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(410, 498);
            this.Controls.Add(this.InvisButton);
            this.Controls.Add(this.SmallBoard);
            this.Controls.Add(this.LargeBoard);
            this.Controls.Add(this.MediumBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Minesweeper.Properties.Resources.MineIcon;
            this.MaximizeBox = false;
            this.Name = "GameOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Minesweeper";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameOptions_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MediumBoard;
        private System.Windows.Forms.Button LargeBoard;
        private System.Windows.Forms.Button SmallBoard;
        private System.Windows.Forms.Button InvisButton;
    }
}