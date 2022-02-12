using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class Cell
    {
        public bool IsAlive { get; set; }
        public bool NextAlive { get; set; }= false;

        public Cell(bool isAlive)
        {
            IsAlive = isAlive;
        }
    }
}
