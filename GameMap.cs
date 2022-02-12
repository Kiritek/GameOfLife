using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class GameMap
    {
        private int mapSize;
        public Cell[,] gamemap;

        public GameMap(bool[,] initialValues, int mapSize)
        {
            this.mapSize = mapSize;
            gamemap = new Cell[mapSize, mapSize];
            for (int x = 0; x < mapSize; x++)
            {
                for (int y = 0; y < mapSize; y++)
                {
                    if (initialValues[x, y])
                    {
                        gamemap[x, y] = new Cell(true);
                    }
                    else
                    {
                        gamemap[x, y] = new Cell(false);
                    }
                }
            }
        }

        public void CheckAlive()
        {
            for (int x = 0; x < mapSize; x++)
            {
                for (int y = 0; y < mapSize; y++)
                {
                    GameRules(gamemap[x,y],CheckNeighbours(x,y));
                }
            }
            NextRound();
        }

        public int CheckNeighbours(int x, int y)
        {
            int numberOfNeighbours = 0;

                if (x - 1 >= 0 && gamemap[x - 1, y].IsAlive)
                {
                    numberOfNeighbours++;
                }
                if (x + 1 < mapSize && gamemap[x + 1, y].IsAlive)
                {
                    numberOfNeighbours++;
                }
                if (y - 1 >= 0 && gamemap[x, y - 1].IsAlive)
                {
                    numberOfNeighbours++;

                }
                if (y + 1 < mapSize && gamemap[x, y + 1].IsAlive)
                {
                    numberOfNeighbours++;
                }

                if ((x + 1 < mapSize && y + 1 < mapSize) && gamemap[x + 1, y + 1].IsAlive)
                {
                    numberOfNeighbours++;
                }
                if ((x - 1 >= 0 && y - 1 >= 0) && gamemap[x - 1, y - 1].IsAlive)
                {
                    numberOfNeighbours++;
                }
                if ((x + 1 < mapSize && y - 1 >= 0) && gamemap[x + 1, y - 1].IsAlive)
                {
                    numberOfNeighbours++;
                }

                if ((x - 1 >= 0 && y + 1 < mapSize) && gamemap[x - 1, y + 1].IsAlive)
                {
                    numberOfNeighbours++;
                }
            
            return numberOfNeighbours;
        }
        public void GameRules(Cell cell, int numberOfNeighbours)
        {

            if (cell.IsAlive && numberOfNeighbours >1 && numberOfNeighbours < 4)
            {
                cell.NextAlive = true;
            }
            else if (!cell.IsAlive && numberOfNeighbours == 3)
            {
                cell.NextAlive = true;
                
                Console.WriteLine(cell.NextAlive);
            }
            else
            {
                cell.NextAlive = false;
            }

        }
        public void NextRound()
        {
            for (int x = 0; x < mapSize; x++)
            {
                for (int y = 0; y < mapSize; y++)
                {
                    if (gamemap[x, y].NextAlive)
                    {
                        gamemap[x, y].IsAlive = true;
                    }
                    else
                    {
                        gamemap[x,y].IsAlive = false;
                    }
                    gamemap[x,y].NextAlive = false;
                }
            }
        }
        public Cell[,] ReturnMap()
        {
            return gamemap;
        }
    }
}

