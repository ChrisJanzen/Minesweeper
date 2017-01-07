using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class GameBoard : Form
    {
        Play Play = new Play();
        Initialize Initialize = new Initialize();

        #region Timer
        Timer GameTimer = new Timer();

        private void Timer_Tick(object sender, EventArgs e)
        {
            ++Global.TIMER;
            TimeLabel.Text = String.Format("{0:00}:{1:00}", Global.TIMER / 60, Global.TIMER % 60);
        }

        private void TimerSetup()
        {
            GameTimer.Interval = 1000;
            GameTimer.Tick += new EventHandler(Timer_Tick);
            GameTimer.Enabled = true;
        }

        private void StopTimer()
        {
            GameTimer.Tick -= new EventHandler(Timer_Tick);
            GameTimer.Enabled = false;
            GameTimer.Dispose();
            GameTimer = null;
        }

        #endregion

        private async void CheckIfGameEnd()
        {
            if(Global.GAMEOVER || Global.GAMEWON)
            {
                StopTimer();

                if(Global.GAMEOVER)
                {
                    #region Save Data
                    ++Properties.Settings.Default.totalGames;

                    if(Global.NUMCOLS == 9)
                    {
                        ++Properties.Settings.Default.easyGames;
                    }

                    if(Global.NUMCOLS == 16)
                    {
                        ++Properties.Settings.Default.mediumGames;
                    }

                    if(Global.NUMCOLS == 30)
                    {
                        ++Properties.Settings.Default.hardGames;
                    }
                    Properties.Settings.Default.Save();
                    #endregion

                    await Task.Delay(Global.DELAY);
                    new GameOver().ShowDialog();
                    Global.GAMEOVER = false;
                    Global.CLOSEAPPLICATION = false;
                    this.Close();
                }

                if(Global.GAMEWON)
                {
                    #region Save Data
                    ++Properties.Settings.Default.totalGames;
                    ++Properties.Settings.Default.totalWins;

                    if(Global.NUMCOLS == 9)
                    {
                        ++Properties.Settings.Default.easyGames;
                        ++Properties.Settings.Default.easyWins;
                        if(Global.TIMER < Properties.Settings.Default.easyBestTime || Properties.Settings.Default.easyBestTime == 0)
                        {
                            Properties.Settings.Default.easyBestTime = Global.TIMER;
                        }
                    }

                    if(Global.NUMCOLS == 16)
                    {
                        ++Properties.Settings.Default.mediumGames;
                        ++Properties.Settings.Default.mediumWins;
                        if(Global.TIMER < Properties.Settings.Default.mediumBestTime || Properties.Settings.Default.mediumBestTime == 0)
                        {
                            Properties.Settings.Default.mediumBestTime = Global.TIMER;
                        }
                    }

                    if(Global.NUMCOLS == 30)
                    {
                        ++Properties.Settings.Default.hardGames;
                        ++Properties.Settings.Default.hardWins;
                        if(Global.TIMER < Properties.Settings.Default.hardBestTime || Properties.Settings.Default.hardBestTime == 0)
                        {
                            Properties.Settings.Default.hardBestTime = Global.TIMER;
                        }
                    }
                    Properties.Settings.Default.Save();
                    #endregion

                    new GameOver().ShowDialog();
                    Global.GAMEWON = false;
                    Global.CLOSEAPPLICATION = false;
                    this.Close();
                }

                if(Global.RETURNTOMENU)
                {
                    Global.RETURNTOMENU = false;
                    Global.MAINMENU.Show();
                }
                else
                {
                    new GameBoard().Show();
                }
            }
        }

        private void CheckGrid()
        {
            if(Global.GRID == null)
            {
                Initialize.SetUp();
                Global.TIMER = 0;
                TimerSetup();
            }
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            InvisButton.Select();

            string buttonCoords = (sender as Button).Name;
            string[] coordsArray = buttonCoords.Split(' ');
            Global.BUTTONROW = Int32.Parse(coordsArray[0]);
            Global.BUTTONCOL = Int32.Parse(coordsArray[1]);

            CheckGrid();

            if(e.Button == MouseButtons.Right)
            {
                Play.OnRightClick();
                MineCounter.Text = String.Format("{0:00}", Global.NUMMINES - Global.FLAGCOUNTER);
            }
        }

        private void Button_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Play.OnLeftClick();
                CheckIfGameEnd();
            }
        }

        private void Button_DoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Play.OnDoubleClick();
                CheckIfGameEnd();
            }
        }

        private void CreateButtons()
        {
            DoubleClickButton[,] buttonArray = new DoubleClickButton[Global.NUMROWS, Global.NUMCOLS];
            #region 9x9
            if(Global.NUMCOLS == 9)
            {
                this.Size = new Size(400, 525);
                int initialX = this.Width / 34;
                int initialY = this.Height / 5;
                int buttonSize = 40;

                for(int row = 0; row < Global.NUMROWS; row++)
                {
                    for(int col = 0; col < Global.NUMCOLS; col++)
                    {
                        DoubleClickButton tempButton = new DoubleClickButton();
                        tempButton.Name = row.ToString() + " " + col.ToString();
                        tempButton.Location = new Point(initialX + (40 * col), initialY + (40 * row));
                        tempButton.Size = new Size(buttonSize, buttonSize);
                        tempButton.AutoSize = false;
                        tempButton.BackColor = SystemColors.MenuHighlight;
                        tempButton.TabStop = false;
                        tempButton.FlatStyle = FlatStyle.Flat;
                        tempButton.Anchor = AnchorStyles.Top;
                        tempButton.MouseDown += new MouseEventHandler(Button_MouseDown);
                        tempButton.MouseClick += new MouseEventHandler(Button_MouseClick);
                        tempButton.MouseDoubleClick += new MouseEventHandler(Button_DoubleClick);
                        buttonArray[row, col] = tempButton;
                    }
                }
            }
            #endregion

            #region 16x16
            if(Global.NUMCOLS == 16)
            {
                this.Size = new Size(600, 700);
                int initialX = this.Width / 40 - 5;
                int initialY = this.Height / 8 + 5;
                int buttonSize = 35;

                for(int row = 0; row < Global.NUMROWS; row++)
                {
                    for(int col = 0; col < Global.NUMCOLS; col++)
                    {
                        DoubleClickButton tempButton = new DoubleClickButton();
                        tempButton.Name = row.ToString() + " " + col.ToString();
                        tempButton.Location = new Point(initialX + (35 * col), initialY + (35 * row));
                        tempButton.Size = new Size(buttonSize, buttonSize);
                        tempButton.AutoSize = false;
                        tempButton.BackColor = SystemColors.MenuHighlight;
                        tempButton.TabStop = false;
                        tempButton.FlatStyle = FlatStyle.Flat;
                        tempButton.Anchor = AnchorStyles.Top;
                        tempButton.MouseDown += new MouseEventHandler(Button_MouseDown);
                        tempButton.MouseClick += new MouseEventHandler(Button_MouseClick);
                        tempButton.MouseDoubleClick += new MouseEventHandler(Button_DoubleClick);
                        buttonArray[row, col] = tempButton;
                    }
                }
            }
            #endregion

            #region 30x16
            if(Global.NUMCOLS == 30)
            {
                this.Size = new Size(1100, 700);
                int initialX = this.Width / 60;
                int initialY = this.Height / 8 + 5;
                int buttonSize = 35;

                for(int row = 0; row < Global.NUMROWS; row++)
                {
                    for(int col = 0; col < Global.NUMCOLS; col++)
                    {
                        DoubleClickButton tempButton = new DoubleClickButton();
                        tempButton.Name = row.ToString() + " " + col.ToString();
                        tempButton.Location = new Point(initialX + (35 * col), initialY + (35 * row));
                        tempButton.Size = new Size(buttonSize, buttonSize);
                        tempButton.AutoSize = false;
                        tempButton.BackColor = SystemColors.MenuHighlight;
                        tempButton.TabStop = false;
                        tempButton.FlatStyle = FlatStyle.Flat;
                        tempButton.Anchor = AnchorStyles.Top;
                        tempButton.MouseDown += new MouseEventHandler(Button_MouseDown);
                        tempButton.MouseClick += new MouseEventHandler(Button_MouseClick);
                        tempButton.MouseDoubleClick += new MouseEventHandler(Button_DoubleClick);
                        buttonArray[row, col] = tempButton;
                    }
                }
            }
            #endregion

            Global.BUTTONARRAY = buttonArray;
            CreateGameInfo();
            AddButtons();
        }

        public void CreateGameInfo()
        {
            PictureBox clockPicture = new PictureBox();
            clockPicture.Image = Properties.Resources.Clock;
            clockPicture.Size = new Size(30, 30);
            clockPicture.Anchor = AnchorStyles.Top;
            clockPicture.Location = new Point(this.Width / 2 - 100, Global.BUTTONARRAY[0,0].Height + 5);
            clockPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            clockPicture.TabStop = false;
            Controls.Add(clockPicture);

            PictureBox minePicture = new PictureBox();
            minePicture.Image = Properties.Resources.MineCounter;
            minePicture.Size = new Size(30, 30);
            minePicture.Anchor = AnchorStyles.Top;
            minePicture.Location = new Point(this.Width / 2 + 10, Global.BUTTONARRAY[0, 0].Height + 5);
            minePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            minePicture.TabStop = false;
            Controls.Add(minePicture);

        }

        public void RestoreButtons()
        {
            for(int row = 0; row < Global.NUMROWS; row++)
            {
                for(int col = 0; col < Global.NUMCOLS; col++)
                {
                    if(Global.GRID[row, col].isChecked)
                    {
                        if(Global.GRID[row, col].numMineNeighbors > 0)
                        {
                            Global.BUTTONARRAY[row, col].Text = Global.GRID[row, col].numMineNeighbors.ToString();
                            Global.BUTTONARRAY[row, col].BackColor = SystemColors.Control;
                            Global.BUTTONARRAY[row, col].Font = new Font("Arial", 16, FontStyle.Bold);
                            Global.BUTTONARRAY[row, col].ForeColor = Global.FONTCOLORS[Global.GRID[row, col].numMineNeighbors];
                            Global.BUTTONARRAY[row, col].FlatAppearance.BorderColor = Color.Black;
                        }
                        else
                        {
                            Global.BUTTONARRAY[row, col].BackColor = SystemColors.Control;
                            Global.BUTTONARRAY[row, col].FlatAppearance.BorderColor = Color.Black;
                        }
                    }

                    if(Global.GRID[row, col].isFlagged)
                    {
                        Global.BUTTONARRAY[row, col].BackgroundImage = Properties.Resources.Flag;
                        Global.BUTTONARRAY[row, col].BackgroundImageLayout = ImageLayout.Stretch;
                        Global.BUTTONARRAY[row, col].BackColor = Color.Gold;
                    }

                    if(Global.GRID[row, col].isGuessed)
                    {
                        Global.BUTTONARRAY[row, col].BackgroundImage = Properties.Resources.Question_Mark;
                        Global.BUTTONARRAY[row, col].BackgroundImageLayout = ImageLayout.Stretch;
                        Global.BUTTONARRAY[row, col].BackColor = SystemColors.MenuHighlight;
                    }
                }
            }
            TimerSetup();
        }

        private void AddButtons()
        {
            for(int row = 0; row < Global.NUMROWS; row++)
            {
                for(int col = 0; col < Global.NUMCOLS; col++)
                {
                    Controls.Add(Global.BUTTONARRAY[row, col]);
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Global.GRID != null)
            {
                Properties.Settings.Default.saveGame = true;
                Properties.Settings.Default.NUMROWS = Global.NUMROWS;
                Properties.Settings.Default.NUMCOLS = Global.NUMCOLS;
                Properties.Settings.Default.NUMMINES = Global.NUMMINES;
                Properties.Settings.Default.TIMER = Global.TIMER;
                Properties.Settings.Default.CHECKEDBUTTONS = Global.CHECKEDBUTTONS;
                Properties.Settings.Default.FLAGCOUNTER = Global.FLAGCOUNTER;
                Properties.Settings.Default.Save();
                Serialize.SerializeToXML();
            }
            Application.Exit();
        }

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopTimer();
            new MainMenu().Show();
            Global.CLOSEAPPLICATION = false;
            this.Close();
        }

        private void x9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.NUMROWS = 9;
            Global.NUMCOLS = 9;
            Global.NUMMINES = 10;
            StopTimer();
            Global.CLOSEAPPLICATION = false;
            this.Close();
            new GameBoard().Show();
        }

        private void x16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.NUMROWS = 16;
            Global.NUMCOLS = 16;
            Global.NUMMINES = 40;
            StopTimer();
            Global.CLOSEAPPLICATION = false;
            this.Close();
            new GameBoard().Show();
        }

        private void x30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.NUMROWS = 16;
            Global.NUMCOLS = 30;
            Global.NUMMINES = 99;
            StopTimer();
            Global.CLOSEAPPLICATION = false;
            this.Close();
            new GameBoard().Show();
        }

        private void GameBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Global.CLOSEAPPLICATION)
            {
                if(Global.GRID != null)
                {
                    Properties.Settings.Default.saveGame = true;
                    Properties.Settings.Default.NUMROWS = Global.NUMROWS;
                    Properties.Settings.Default.NUMCOLS = Global.NUMCOLS;
                    Properties.Settings.Default.NUMMINES = Global.NUMMINES;
                    Properties.Settings.Default.TIMER = Global.TIMER;
                    Properties.Settings.Default.CHECKEDBUTTONS = Global.CHECKEDBUTTONS;
                    Properties.Settings.Default.FLAGCOUNTER = Global.FLAGCOUNTER;
                    Properties.Settings.Default.Save();
                    Serialize.SerializeToXML();
                }
                Application.Exit();
            }
        }

        public GameBoard()
        {
            InitializeComponent();
            Global.CLOSEAPPLICATION = true;

            if(Properties.Settings.Default.saveGame)
            {
                TimeLabel.Text = String.Format("{0:00}:{1:00}", Global.TIMER / 60, Global.TIMER % 60);
                MineCounter.Text = Convert.ToString(Global.NUMMINES - Global.FLAGCOUNTER);
                Properties.Settings.Default.saveGame = false;
                Properties.Settings.Default.Save();
                CreateButtons();
                RestoreButtons();
            }
            else
            {
                TimeLabel.Text = "00:00";
                MineCounter.Text = Convert.ToString(Global.NUMMINES);
                Global.GRID = null;
                Global.BUTTONARRAY = null;
                Global.CHECKEDBUTTONS = 0;
                Global.FLAGCOUNTER = 0;
                Global.TIMER = 0;
                CreateButtons();
            }
        }
    }
}