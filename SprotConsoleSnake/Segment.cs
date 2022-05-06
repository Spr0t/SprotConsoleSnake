using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotConsoleSnake
{
    public class Segment
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Segment(int X,int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
