using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator
{
    internal class LandscapeMap
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        //Карта и графика её
        public Cell[,] Field { get; set; }
        public Form1 Simulation { get; set; }
        public int Res { get; set; }
        public LandscapeMap(int width, int height, Form1 form)
        {
            Simulation = form;
            Width = width;
            Height = height;
            Field = new Cell[Width, Height];

            for (int x = 0; x < Height; x++)
            {
                for (int y = 0; y < Width; y++)
                {
                    Field[x, y] = new Cell(x, y);
                }
            }
        }
    }
}
