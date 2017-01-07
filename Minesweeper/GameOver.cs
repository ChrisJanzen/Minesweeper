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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
            Global.CLOSEAPPLICATION = true;

            if(Global.GAMEOVER)
            {
                EndScreenLabel.Text = "Game Over!";
            }
            else
            {
                EndScreenLabel.Text = "You Won!";
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            Global.CLOSEAPPLICATION = false;
            this.Close();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Global.RETURNTOMENU = true;
            Global.CLOSEAPPLICATION = false;
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void GameOver_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Global.CLOSEAPPLICATION)
            {
                Application.Exit();
            }
        }
    }
}