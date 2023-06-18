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
        public int Height { get; set; }
        public Color Color { get; private set; }
        public Cell(int x, int y, int h = 0)
        {
            X = x;
            Y = y;
            Height = h;
            Random rand = new Random();
            Color = Color.FromArgb(255, rand.Next(1, 255), rand.Next(1, 255), rand.Next(1, 255));
        }

        public void updateColor()
        {
            double step = 255 / 10;
            Color = Color.FromArgb(255, 0, (int)(Height * step), 0);
        }
    }
}
