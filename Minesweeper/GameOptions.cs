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
    public partial class GameOptions : Form
    {
        public GameOptions()
        {
            InitializeComponent();
        }

        private void SmallBoard_Click(object sender, EventArgs e)
        {
            Global.NUMROWS = 9;
            Global.NUMCOLS = 9;
            Global.NUMMINES = 10;
            Global.DELAY = 1000;
            Global.CLOSEAPPLICATION = false;
            this.Close();
            new GameBoard().Show();
        }

        private void MediumBoard_Click(object sender, EventArgs e)
        {
            Global.NUMROWS = 16;
            Global.NUMCOLS = 16;
            Global.NUMMINES = 40;
            Global.DELAY = 1600;
            Global.CLOSEAPPLICATION = false;
            this.Close();
            new GameBoard().Show();
        }

        private void LargeBoard_Click(object sender, EventArgs e)
        {
            Global.NUMROWS = 16;
            Global.NUMCOLS = 30;
            Global.NUMMINES = 99;
            Global.DELAY = 2000;
            Global.CLOSEAPPLICATION = false;
            this.Close();
            new GameBoard().Show();
        }

        private void GameOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Global.CLOSEAPPLICATION)
            {
                Minesweeper.Properties.Settings.Default.saveGame = false;
                Application.Exit();
            }
        }
    }
}