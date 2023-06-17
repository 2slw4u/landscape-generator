using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator
{
    internal class Cell
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Color color { get; private set; }
        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            Random rand = new Random();
            color = Color.FromArgb(255, rand.Next(1, 255), rand.Next(1, 255), rand.Next(1, 255));
        }
    }
}
