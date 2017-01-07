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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            InvisButton.Select();
            toggleSoundText();
        }

        private void toggleSoundText()
        {
            if(Properties.Settings.Default.playSounds)
                toggleSound.Text = "Sound Enabled";
            else
                toggleSound.Text = "Sound Disabled";
        }

        private void toggleSound_Click(object sender, EventArgs e)
        {
            InvisButton.Select();
            Properties.Settings.Default.playSounds = !Properties.Settings.Default.playSounds;
            Properties.Settings.Default.Save();
            toggleSoundText();
        }

        private void clearRecords_Click(object sender, EventArgs e)
        {
            InvisButton.Select();
            DialogResult confirm = MessageBox.Show("Are you sure?\nAll records will be deleted.", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(confirm == DialogResult.Yes)
            {
                Properties.Settings.Default.easyBestTime = 0;
                Properties.Settings.Default.easyGames = 0;
                Properties.Settings.Default.easyWins = 0;
                Properties.Settings.Default.mediumBestTime = 0;
                Properties.Settings.Default.mediumGames = 0;
                Properties.Settings.Default.mediumWins = 0;
                Properties.Settings.Default.hardBestTime = 0;
                Properties.Settings.Default.hardGames = 0;
                Properties.Settings.Default.hardWins = 0;
                Properties.Settings.Default.totalGames = 0;
                Properties.Settings.Default.totalWins = 0;
                Properties.Settings.Default.Save();
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Global.MAINMENU.Show();
            Global.CLOSEAPPLICATION = false;
            this.Close();
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Global.CLOSEAPPLICATION)
            {
                Properties.Settings.Default.saveGame = false;
                Application.Exit();
            }
        }
    }
}
