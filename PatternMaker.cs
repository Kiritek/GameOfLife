using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class PatternMaker
    {
        private int mapSize;
        public PatternMaker(int mapSize)
        {
            this.mapSize = mapSize; 
        }
       public bool[,] Glider()
        {
            bool[,] pattern = new bool[mapSize, mapSize];
            pattern[0, 1] = true;
            pattern[2, 0] = true;
            pattern[2, 1] = true;
            pattern[2, 2] = true;
            pattern[1, 2] = true;
            return pattern;
        }

        public bool[,] LightWeightSpaceShip()
        {
            bool[,] pattern = new bool[mapSize, mapSize];
            pattern[3, 3] = true;
            pattern[3, 4] = true;
            pattern[4, 3] = true;
            pattern[4, 4] = true;
            pattern[4, 5] = true;
            pattern[5, 5] = true;
            pattern[5, 4] = true;
            pattern[5, 5] = true;
            pattern[6, 2] = true;
            pattern[6, 3] = true;
            pattern[6, 4] = true;
            pattern[7, 3] = true;
            return pattern;
        }
        public bool[,] MiddleWeightSpaceShip()
        {
            bool[,] pattern = new bool[mapSize, mapSize];
            pattern[2, 2] = true;
            pattern[2, 4] = true;
            pattern[3, 5] = true;
            pattern[4, 1] = true;
            pattern[4, 5] = true;
            pattern[5, 5] = true;
            pattern[6, 2] = true;
            pattern[6, 5] = true;
            pattern[7, 3] = true;
            pattern[7, 4] = true;
            pattern[7, 5] = true;
            return pattern;
        }
        public bool[,] HeavyWeightSpaceShip()
        {
            bool[,] pattern = new bool[mapSize, mapSize];
            pattern[2, 2] = true;
            pattern[2, 4] = true;
            pattern[3, 5] = true;
            pattern[4, 1] = true;
            pattern[4, 5] = true;
            pattern[5, 1] = true;
            pattern[5, 5] = true;
            pattern[6, 5] = true;
            pattern[7, 2] = true;
            pattern[7, 5] = true;
            pattern[8, 3] = true;
            pattern[8, 4] = true;
            pattern[8, 5] = true;

            return pattern;
        }
        public bool[,] Pulsar()
        {
            bool[,] pattern = new bool[mapSize, mapSize];
            pattern[2, 4] = true;
            pattern[2, 5] = true;
            pattern[2, 6] = true;
            pattern[2, 10] = true;
            pattern[2, 11] = true;
            pattern[2, 12] = true;
            pattern[4, 2] = true;
            pattern[4, 7] = true;
            pattern[4, 9] = true;
            pattern[4, 14] = true;
            pattern[5, 2] = true;
            pattern[5, 7] = true;
            pattern[5, 9] = true;
            pattern[5, 14] = true;
            pattern[6, 2] = true;
            pattern[6, 7] = true;
            pattern[6, 9] = true;
            pattern[6, 14] = true;
            pattern[7, 4] = true;
            pattern[7, 5] = true;
            pattern[7, 6] = true;
            pattern[7, 10] = true;
            pattern[7, 11] = true;
            pattern[7, 12] = true;
            pattern[9, 4] = true;
            pattern[9, 5] = true;
            pattern[9, 6] = true;
            pattern[9, 10] = true;
            pattern[9, 11] = true;
            pattern[9, 12] = true;
            pattern[10, 2] = true;
            pattern[10, 7] = true;
            pattern[10, 9] = true;
            pattern[10, 14] = true;
            pattern[11, 2] = true;
            pattern[11, 7] = true;
            pattern[11, 9] = true;
            pattern[11, 14] = true;
            pattern[12, 2] = true;
            pattern[12, 7] = true;
            pattern[12, 9] = true;
            pattern[12, 14] = true;
            pattern[14, 4] = true;
            pattern[14, 5] = true;
            pattern[14, 6] = true;
            pattern[14, 10] = true;
            pattern[14, 11] = true;
            pattern[14, 12] = true;

            return pattern;
        }
        public bool[,] Random()
        {
            Random rnd = new();
            bool[,] pattern = new bool[mapSize, mapSize];

            for (int x = 0; x < mapSize; x++)
            {
                for (int y = 0; y < mapSize; y++)
                {
                    if (rnd.Next(1, 3) == 1)
                    {
                        pattern[x, y] = true;
                    }
                    else
                    {
                        pattern[x, y] = false;
                    }

                }
            }
            return pattern;
        }

    }
}
