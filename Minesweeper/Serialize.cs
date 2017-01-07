using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Minesweeper
{
    class Serialize
    {
        private static void CheckDirectory()
        {
            if(!Directory.Exists(Global.DATALOCATION))
            {
                Directory.CreateDirectory(Global.DATALOCATION);
            }
        }

        private static GridElement[] FlattenGrid()
        {
            int i = 0;
            GridElement[] flatGrid = new GridElement[Global.NUMROWS * Global.NUMCOLS];

            for(int row = 0; row < Global.NUMROWS; row++)
            {
                for(int col = 0; col < Global.NUMCOLS; col++)
                {
                    flatGrid[i] = Global.GRID[row, col];
                    ++i;
                }
            }
            return flatGrid;
        }

        private static void RestoreGrid(GridElement[] flatGrid)
        {
            int i = 0;
            GridElement[,] restoredGrid = new GridElement[Properties.Settings.Default.NUMROWS, Properties.Settings.Default.NUMCOLS];
            for(int row = 0; row < Properties.Settings.Default.NUMROWS; row++)
            {
                for(int col = 0; col < Properties.Settings.Default.NUMCOLS; col++)
                {
                    restoredGrid[row, col] = flatGrid[i];
                    ++i;
                }
            }

            Global.GRID = restoredGrid;
            Global.NUMROWS = Properties.Settings.Default.NUMROWS;
            Global.NUMCOLS = Properties.Settings.Default.NUMCOLS;
            Global.NUMMINES = Properties.Settings.Default.NUMMINES;
            Global.TIMER = Properties.Settings.Default.TIMER;
            Global.CHECKEDBUTTONS = Properties.Settings.Default.CHECKEDBUTTONS;
            Global.FLAGCOUNTER = Properties.Settings.Default.FLAGCOUNTER;
            Global.TIMER = Properties.Settings.Default.TIMER;
        }

        public static void SerializeToXML()
        {
            CheckDirectory();
            XmlSerializer serializer = new XmlSerializer(typeof(GridElement[]));
            TextWriter textWriter = new StreamWriter(Global.DATALOCATION + @"\Data.xml");
            serializer.Serialize(textWriter, FlattenGrid());
            textWriter.Close();
        }

        public static void DeserializeFromXML()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(GridElement[]));
            TextReader textReader = new StreamReader(Global.DATALOCATION + @"\Data.xml");
            RestoreGrid((GridElement[])deserializer.Deserialize(textReader));
            textReader.Close();
        }
    }
}
