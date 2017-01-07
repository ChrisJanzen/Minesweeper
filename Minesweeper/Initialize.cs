using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Initialize
    {
        GridElement[,] gameGrid;

        private void CreateGrid()
        {
            gameGrid = new GridElement[Global.NUMROWS, Global.NUMCOLS];

            for(int row = 0; row < Global.NUMROWS; row++)
            {
                for(int col = 0; col < Global.NUMCOLS; col++)
                {
                    gameGrid[row, col] = new GridElement();
                }
            }
        }

        private void AddMines()
        {
            Random rnd = new Random();
            int row, col;
            int mineCounter = Global.NUMMINES;

            while(mineCounter > 0)
            {
                row = rnd.Next(0, Global.NUMROWS);
                col = rnd.Next(0, Global.NUMCOLS);
                if(gameGrid[row, col].isMine)
                    continue;
                if(row == Global.BUTTONROW && col == Global.BUTTONCOL)
                    continue;
                if(row < Global.NUMROWS - 1 && col < Global.NUMCOLS - 1)
                    if(Global.BUTTONROW == row + 1 && Global.BUTTONCOL == col + 1)
                        continue;
                if(row < Global.NUMROWS - 1)
                    if(Global.BUTTONROW == row + 1 && Global.BUTTONCOL == col)
                        continue;
                if(row < Global.NUMROWS - 1 && col > 0)
                    if(Global.BUTTONROW == row + 1 && Global.BUTTONCOL == col - 1)
                        continue;
                if(col < Global.NUMCOLS - 1)
                    if(Global.BUTTONROW == row && Global.BUTTONCOL == col + 1)
                        continue;
                if(col > 0)
                    if(Global.BUTTONROW == row && Global.BUTTONCOL == col - 1)
                        continue;
                if(row > 0 && col < Global.NUMCOLS - 1)
                    if(Global.BUTTONROW == row - 1 && Global.BUTTONCOL == col + 1)
                        continue;
                if(row > 0)
                    if(Global.BUTTONROW == row - 1 && Global.BUTTONCOL == col)
                        continue;
                if(row > 0 && col > 0)
                    if(Global.BUTTONROW == row - 1 && Global.BUTTONCOL == col - 1)
                        continue;

                gameGrid[row, col].isMine = true;
                mineCounter--;
            }
        }

        private void CountMines()
        {
            for(int row = 0; row < Global.NUMROWS; row++)
            {
                for(int col = 0; col < Global.NUMCOLS; col++)
                {
                    if(gameGrid[row, col].isMine)
                    {
                        continue;
                    }
                    if(row > 0 && col > 0)
                        if(gameGrid[row - 1, col - 1].isMine)
                            ++gameGrid[row, col].numMineNeighbors;
                    if(row > 0)
                        if(gameGrid[row - 1, col].isMine)
                            ++gameGrid[row, col].numMineNeighbors;
                    if(row > 0 && col < Global.NUMCOLS - 1)
                        if(gameGrid[row - 1, col + 1].isMine)
                            ++gameGrid[row, col].numMineNeighbors;
                    if(col > 0)
                        if(gameGrid[row, col - 1].isMine)
                            ++gameGrid[row, col].numMineNeighbors;
                    if(col < Global.NUMCOLS - 1)
                        if(gameGrid[row, col + 1].isMine)
                            ++gameGrid[row, col].numMineNeighbors;
                    if(row < Global.NUMROWS - 1 && col > 0)
                        if(gameGrid[row + 1, col - 1].isMine)
                            ++gameGrid[row, col].numMineNeighbors;
                    if(row < Global.NUMROWS - 1)
                        if(gameGrid[row + 1, col].isMine)
                            ++gameGrid[row, col].numMineNeighbors;
                    if(row < Global.NUMROWS - 1 && col < Global.NUMCOLS - 1)
                        if(gameGrid[row + 1, col + 1].isMine)
                            ++gameGrid[row, col].numMineNeighbors;
                }
            }
        }

        public void SetUp()
        {
            CreateGrid();
            AddMines();
            CountMines();
            Global.GRID = gameGrid;
        }
    }
}