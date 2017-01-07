using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Minesweeper
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void StartNewGame()
        {
            Minesweeper.Properties.Settings.Default.saveGame = false;
            Minesweeper.Properties.Settings.Default.Save();
            GameOptions GameOptions = new GameOptions();
            GameOptions.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            GameOptions.Show();
            this.Hide();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            InvisButton.Select();

            if(Minesweeper.Properties.Settings.Default.saveGame && File.Exists(Global.DATALOCATION + @"\Data.xml"))
            {
                DialogResult continueGame = MessageBox.Show("Saved game detected, continue?", "Continue Game", MessageBoxButtons.YesNo, MessageBoxIcon.None);

                if(continueGame == DialogResult.Yes)
                {
                    Serialize.DeserializeFromXML();
                    new GameBoard().Show();
                    this.Hide();
                }
                else
                {
                    StartNewGame();
                }
            }
            else
            {

                StartNewGame();
            }
        }

        private void Records_Click(object sender, EventArgs e)
        {
            InvisButton.Select();
            new Records().Show();
            this.Hide();
        }

        private void Options_Click(object sender, EventArgs e)
        {
            InvisButton.Select();
            Options Options = new Options();
            Options.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            Options.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Minesweeper.Properties.Settings.Default.saveGame = false;
            Application.Exit();
        }
    }
}