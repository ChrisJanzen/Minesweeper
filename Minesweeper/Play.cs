using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Minesweeper
{
    class Play
    {
        private void PlaySound(string sound)
        {
            if(Properties.Settings.Default.playSounds)
            {
                switch(sound)
                {
                    case "badClick":
                        Global.BADCLICK.Play();
                        break;
                    case "click":
                        Global.CLICK.Play();
                        break;
                    case "rightClick":
                        Global.CLICK.Play();
                        break;
                    case "explosion":
                        Global.EXPLOSION.Play();
                        break;
                }
            }
        }

        private async void CheckGameOver(int row, int col)
        {
            if(Global.GRID[row, col].isMine)
            {
                Global.BUTTONARRAY[row, col].BackgroundImage = Properties.Resources.Mine;
                Global.BUTTONARRAY[row, col].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                Global.BUTTONARRAY[row, col].BackColor = Color.Orange;
                Global.GRID[row, col].isChecked = true;

                Global.GAMEOVER = true;

                for(int r = 0; r < Global.NUMROWS; r++)
                {
                    for(int c = 0; c < Global.NUMCOLS; c++)
                    {
                        Global.BUTTONARRAY[r, c].Enabled = false;
                    }
                }

                PlaySound("explosion");

                await Task.Delay(150);

                for(int r = 0; r < Global.NUMROWS; r++)
                {
                    for(int c = 0; c < Global.NUMCOLS; c++)
                    {
                        if(Global.GRID[r, c].isMine && !Global.GRID[r, c].isChecked && !Global.GRID[r, c].isFlagged)
                        {
                            Global.BUTTONARRAY[r, c].BackgroundImage = Properties.Resources.Mine;
                            Global.BUTTONARRAY[r, c].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            Global.BUTTONARRAY[r, c].BackColor = Color.Red;
                            if(c % 3 == 0)

                                await Task.Delay(1);
                        }

                        if(!Global.GRID[r, c].isMine && !Global.GRID[r, c].isChecked && Global.GRID[r, c].isFlagged && !Global.GRID[r, c].isGuessed)
                        {
                            Global.BUTTONARRAY[r, c].BackgroundImage = Properties.Resources.WrongFlag;
                            Global.BUTTONARRAY[r, c].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            Global.BUTTONARRAY[r, c].BackColor = Color.Gold;
                            await Task.Delay(1);
                        }
                    }
                }
            }
        }

        private void CheckWin()
        {
            if(Global.CHECKEDBUTTONS == Global.NUMROWS * Global.NUMCOLS - Global.NUMMINES)
            {
                for(int row = 0; row < Global.NUMROWS; row++)
                {
                    for(int col = 0; col < Global.NUMCOLS; col++)
                    {
                        if(Global.GRID[row, col].isMine && !Global.GRID[row, col].isFlagged)
                        {
                            Global.BUTTONARRAY[row, col].BackgroundImage = Properties.Resources.Mine;
                            Global.BUTTONARRAY[row, col].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            Global.BUTTONARRAY[row, col].BackColor = Color.Green;
                        }
                    }
                }
                Global.GAMEWON = true;
            }
        }

        private void LeftClick(int row, int col)
        {

            if(Global.GRID[row, col].isMine || Global.GRID[row, col].isChecked)
                return;

            if(!Global.GRID[row, col].isChecked && !Global.GRID[row, col].isFlagged)
            {
                Global.GRID[row, col].isChecked = true;
                ++Global.CHECKEDBUTTONS;

                if(Global.GRID[row, col].isGuessed)
                {
                    Global.GRID[row, col].isGuessed = false;
                    Global.BUTTONARRAY[row, col].BackgroundImage = null;
                }

                if(Global.GRID[row, col].numMineNeighbors > 0)
                {
                    Global.BUTTONARRAY[row, col].Text = Global.GRID[row, col].numMineNeighbors.ToString();
                    Global.BUTTONARRAY[row, col].BackColor = SystemColors.Control;
                    Global.BUTTONARRAY[row, col].Font = new Font("Arial", 16, FontStyle.Bold);
                    Global.BUTTONARRAY[row, col].ForeColor = Global.FONTCOLORS[Global.GRID[row, col].numMineNeighbors];
                    Global.BUTTONARRAY[row, col].FlatAppearance.BorderColor = Color.Black;
                }

                if(Global.GRID[row, col].numMineNeighbors == 0)
                {
                    Global.BUTTONARRAY[row, col].BackColor = SystemColors.Control;
                    Global.BUTTONARRAY[row, col].FlatAppearance.BorderColor = Color.Black;
                    if(row > 0 && col > 0)
                        LeftClick(row - 1, col - 1);
                    if(row > 0)
                        LeftClick(row - 1, col);
                    if(row > 0 && col < Global.NUMCOLS - 1)
                        LeftClick(row - 1, col + 1);
                    if(col > 0)
                        LeftClick(row, col - 1);
                    if(col < Global.NUMCOLS - 1)
                        LeftClick(row, col + 1);
                    if(row < Global.NUMROWS - 1 && col > 0)
                        LeftClick(row + 1, col - 1);
                    if(row < Global.NUMROWS - 1)
                        LeftClick(row + 1, col);
                    if(row < Global.NUMROWS - 1 && col < Global.NUMCOLS - 1)
                        LeftClick(row + 1, col + 1);
                }
            }
        }

        private void RightClick()
        {
            if(!Global.GRID[Global.BUTTONROW, Global.BUTTONCOL].isChecked)
            {
                PlaySound("rightClick");
                if(!Global.GRID[Global.BUTTONROW, Global.BUTTONCOL].isFlagged && !Global.GRID[Global.BUTTONROW, Global.BUTTONCOL].isGuessed)
                {
                    Global.GRID[Global.BUTTONROW, Global.BUTTONCOL].isFlagged = true;
                    ++Global.FLAGCOUNTER;

                    Global.BUTTONARRAY[Global.BUTTONROW, Global.BUTTONCOL].BackgroundImage = Properties.Resources.Flag;
                    Global.BUTTONARRAY[Global.BUTTONROW, Global.BUTTONCOL].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    Global.BUTTONARRAY[Global.BUTTONROW, Global.BUTTONCOL].BackColor = Color.Gold;
                    return;
                }

                if(Global.GRID[Global.BUTTONROW, Global.BUTTONCOL].isFlagged)
                {
                    Global.GRID[Global.BUTTONROW, Global.BUTTONCOL].isFlagged = false;
                    --Global.FLAGCOUNTER;

                    Global.GRID[Global.BUTTONROW, Global.BUTTONCOL].isGuessed = true;
      
                    Global.BUTTONARRAY[Global.BUTTONROW, Global.BUTTONCOL].BackgroundImage = Properties.Resources.Question_Mark;
                    Global.BUTTONARRAY[Global.BUTTONROW, Global.BUTTONCOL].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    Global.BUTTONARRAY[Global.BUTTONROW, Global.BUTTONCOL].BackColor = SystemColors.MenuHighlight;
                    return;
                }

                if(Global.GRID[Global.BUTTONROW, Global.BUTTONCOL].isGuessed)
                {
                    Global.GRID[Global.BUTTONROW, Global.BUTTONCOL].isGuessed = false;

                    Global.BUTTONARRAY[Global.BUTTONROW, Global.BUTTONCOL].BackgroundImage = null;
                    return;
                }
            }

        }

        private void DoubleClick()
        {
            if(Global.GRID[Global.BUTTONROW, Global.BUTTONCOL].isChecked)
            {
                int tempFlagCounter = 0;

                #region Check number of flags around square
                if(Global.BUTTONROW > 0 && Global.BUTTONCOL > 0)
                    if(Global.GRID[Global.BUTTONROW - 1, Global.BUTTONCOL - 1].isFlagged)
                        ++tempFlagCounter;
                if(Global.BUTTONROW > 0)
                    if(Global.GRID[Global.BUTTONROW - 1, Global.BUTTONCOL].isFlagged)
                        ++tempFlagCounter;
                if(Global.BUTTONROW > 0 && Global.BUTTONCOL < Global.NUMCOLS - 1)
                    if(Global.GRID[Global.BUTTONROW - 1, Global.BUTTONCOL + 1].isFlagged)
                        ++tempFlagCounter;
                if(Global.BUTTONCOL > 0)
                    if(Global.GRID[Global.BUTTONROW, Global.BUTTONCOL - 1].isFlagged)
                        ++tempFlagCounter;
                if(Global.BUTTONCOL < Global.NUMCOLS - 1)
                    if(Global.GRID[Global.BUTTONROW, Global.BUTTONCOL + 1].isFlagged)
                        ++tempFlagCounter;
                if(Global.BUTTONROW < Global.NUMROWS - 1 && Global.BUTTONCOL > 0)
                    if(Global.GRID[Global.BUTTONROW + 1, Global.BUTTONCOL - 1].isFlagged)
                        ++tempFlagCounter;
                if(Global.BUTTONROW < Global.NUMROWS - 1)
                    if(Global.GRID[Global.BUTTONROW + 1, Global.BUTTONCOL].isFlagged)
                        ++tempFlagCounter;
                if(Global.BUTTONROW < Global.NUMROWS - 1 && Global.BUTTONCOL < Global.NUMCOLS - 1)
                    if(Global.GRID[Global.BUTTONROW + 1, Global.BUTTONCOL + 1].isFlagged)
                        ++tempFlagCounter;
                #endregion

                #region Click around checked square
                if(tempFlagCounter == Global.GRID[Global.BUTTONROW, Global.BUTTONCOL].numMineNeighbors)
                {
                    if(Global.BUTTONROW > 0 && Global.BUTTONCOL > 0)
                        if(!Global.GRID[Global.BUTTONROW - 1, Global.BUTTONCOL - 1].isChecked && !Global.GRID[Global.BUTTONROW - 1, Global.BUTTONCOL - 1].isFlagged)
                        {
                            CheckGameOver(Global.BUTTONROW - 1, Global.BUTTONCOL - 1);
                            LeftClick(Global.BUTTONROW - 1, Global.BUTTONCOL - 1);
                        }
                    if(Global.BUTTONROW > 0)
                        if(!Global.GRID[Global.BUTTONROW - 1, Global.BUTTONCOL].isChecked && !Global.GRID[Global.BUTTONROW - 1, Global.BUTTONCOL].isFlagged)
                        {
                            CheckGameOver(Global.BUTTONROW - 1, Global.BUTTONCOL);
                            LeftClick(Global.BUTTONROW - 1, Global.BUTTONCOL);
                        }
                    if(Global.BUTTONROW > 0 && Global.BUTTONCOL < Global.NUMCOLS - 1)
                        if(!Global.GRID[Global.BUTTONROW - 1, Global.BUTTONCOL + 1].isChecked && !Global.GRID[Global.BUTTONROW - 1, Global.BUTTONCOL + 1].isFlagged)
                        {
                            CheckGameOver(Global.BUTTONROW - 1, Global.BUTTONCOL + 1);
                            LeftClick(Global.BUTTONROW - 1, Global.BUTTONCOL + 1);
                        }
                    if(Global.BUTTONCOL > 0)
                        if(!Global.GRID[Global.BUTTONROW, Global.BUTTONCOL - 1].isChecked && !Global.GRID[Global.BUTTONROW, Global.BUTTONCOL - 1].isFlagged)
                        {
                            CheckGameOver(Global.BUTTONROW, Global.BUTTONCOL - 1);
                            LeftClick(Global.BUTTONROW, Global.BUTTONCOL - 1);
                        }
                    if(Global.BUTTONCOL < Global.NUMCOLS - 1)
                        if(!Global.GRID[Global.BUTTONROW, Global.BUTTONCOL + 1].isChecked && !Global.GRID[Global.BUTTONROW, Global.BUTTONCOL + 1].isFlagged)
                        {
                            CheckGameOver(Global.BUTTONROW, Global.BUTTONCOL + 1);
                            LeftClick(Global.BUTTONROW, Global.BUTTONCOL + 1);
                        }
                    if(Global.BUTTONROW < Global.NUMROWS - 1 && Global.BUTTONCOL > 0)
                        if(!Global.GRID[Global.BUTTONROW + 1, Global.BUTTONCOL - 1].isChecked && !Global.GRID[Global.BUTTONROW + 1, Global.BUTTONCOL - 1].isFlagged)
                        {
                            CheckGameOver(Global.BUTTONROW + 1, Global.BUTTONCOL - 1);
                            LeftClick(Global.BUTTONROW + 1, Global.BUTTONCOL - 1);
                        }
                    if(Global.BUTTONROW < Global.NUMROWS - 1)
                        if(!Global.GRID[Global.BUTTONROW + 1, Global.BUTTONCOL].isChecked && !Global.GRID[Global.BUTTONROW + 1, Global.BUTTONCOL].isFlagged)
                        {
                            CheckGameOver(Global.BUTTONROW + 1, Global.BUTTONCOL);
                            LeftClick(Global.BUTTONROW + 1, Global.BUTTONCOL);
                        }
                    if(Global.BUTTONROW < Global.NUMROWS - 1 && Global.BUTTONCOL < Global.NUMCOLS - 1)
                        if(!Global.GRID[Global.BUTTONROW + 1, Global.BUTTONCOL + 1].isChecked && !Global.GRID[Global.BUTTONROW + 1, Global.BUTTONCOL + 1].isFlagged)
                        {
                            CheckGameOver(Global.BUTTONROW + 1, Global.BUTTONCOL + 1);
                            LeftClick(Global.BUTTONROW + 1, Global.BUTTONCOL + 1);
                        }
                }
                else
                {
                    PlaySound("badClick");
                }
                #endregion
            }
        }

        public void OnLeftClick()
        {
            if(Global.GRID[Global.BUTTONROW, Global.BUTTONCOL].isFlagged)
            {
                PlaySound("badClick");
                return;
            }
            PlaySound("click");
            CheckGameOver(Global.BUTTONROW, Global.BUTTONCOL);
            LeftClick(Global.BUTTONROW, Global.BUTTONCOL);
            CheckWin();
        }

        public void OnRightClick()
        {
            RightClick();
        }

        public void OnDoubleClick()
        {
            DoubleClick();
            CheckWin();
        }
    }
}