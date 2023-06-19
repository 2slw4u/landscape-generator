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
        public List<Cell> getNeighbours(Cell cell)
        {
            List<Cell> result = new List<Cell>();
            int x = cell.X;
            int y = cell.Y;
            for (int xAdditive = -1; xAdditive <= 1; ++xAdditive)
            {
                for (int yAdditive = -1; yAdditive <= 1; ++yAdditive)
                {
                    if (x + xAdditive >= 0 && y + yAdditive >= 0 && x + xAdditive < Width && y + yAdditive < Height && !(xAdditive == 0 && yAdditive == 0))
                    {
                        result.Add(this.Field[x+xAdditive, y+yAdditive]);
                    }
                }
            }
            return result;
        }
    }
}
