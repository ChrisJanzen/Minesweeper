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
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
            Global.CLOSEAPPLICATION = true;

            totalGames.Text = Convert.ToString(Properties.Settings.Default.totalGames);
            totalWins.Text = Convert.ToString(Properties.Settings.Default.totalWins);
            easyGames.Text = Convert.ToString(Properties.Settings.Default.easyGames);
            easyWins.Text = Convert.ToString(Properties.Settings.Default.easyWins);
            easyBestTime.Text = String.Format("{0:00}:{1:00}", Properties.Settings.Default.easyBestTime / 60, Properties.Settings.Default.easyBestTime % 60);
            mediumGames.Text = Convert.ToString(Properties.Settings.Default.mediumGames);
            mediumWins.Text = Convert.ToString(Properties.Settings.Default.mediumWins);
            mediumBestTime.Text = String.Format("{0:00}:{1:00}", Properties.Settings.Default.mediumBestTime / 60, Properties.Settings.Default.mediumBestTime % 60);
            hardGames.Text = Convert.ToString(Properties.Settings.Default.hardGames);
            hardWins.Text = Convert.ToString(Properties.Settings.Default.hardWins);
            hardBestTime.Text = String.Format("{0:00}:{1:00}", Properties.Settings.Default.hardBestTime / 60, Properties.Settings.Default.hardBestTime % 60);
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Global.MAINMENU.Show();
            Global.CLOSEAPPLICATION = false;
            this.Close();
        }

        private void Records_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Global.CLOSEAPPLICATION)
            {
                Properties.Settings.Default.saveGame = false;
                Application.Exit();
            }
        }
    }
}