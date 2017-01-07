using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Media;

namespace Minesweeper
{
    public class Global
    {
        public static string DATALOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Minesweeper");
        public static int TIMER;
        public static int DELAY;
        public static int NUMROWS, NUMCOLS, NUMMINES;
        public static int BUTTONROW, BUTTONCOL;
        public static int CHECKEDBUTTONS;
        public static int FLAGCOUNTER;
        public static bool CLOSEAPPLICATION = true;
        public static bool GAMEOVER = false, RETURNTOMENU = false, GAMEWON = false;
        public static Color[] FONTCOLORS = {Color.Black, Color.Blue, Color.Green, Color.Red, Color.Purple, Color.Maroon, Color.Turquoise, Color.Black, Color.Gray};
        public static GridElement[,] GRID;
        public static DoubleClickButton[,] BUTTONARRAY;
        public static MainMenu MAINMENU = new MainMenu();

        public static SoundPlayer BADCLICK = new SoundPlayer(Minesweeper.Properties.Resources.badClick);
        public static SoundPlayer CLICK = new SoundPlayer(Minesweeper.Properties.Resources.click);
        public static SoundPlayer REMOVEFLAG = new SoundPlayer(Minesweeper.Properties.Resources.rightClick);
        public static SoundPlayer EXPLOSION = new SoundPlayer(Minesweeper.Properties.Resources.explosion);
    }

    public class GridElement
    {
        public bool isMine = false, isGuessed = false, isFlagged = false, isChecked = false;
        public int numMineNeighbors = 0, checkedClicks = 0;
    }

    public class DoubleClickButton : Button
    {
        public DoubleClickButton()
        {
            SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
        }
    }
}
