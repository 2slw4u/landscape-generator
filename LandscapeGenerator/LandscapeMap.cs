using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator
{
    internal class LandscapeMap
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Resolution { get; private set; }
        //Карта и графика её
        public Cell[,] Field { get; set; }
        public Form1 Simulation { get; set; }
        public int Res { get; set; }
        public MapUpdater MapUpdater { get; private set; }
        public LandscapeMap(int width, int height, Form1 form)
        {
            Simulation = form;
            Resolution = Simulation.resolution;
            Width = width;
            Height = height;
            Field = new Cell[Width, Height];
            MapUpdater = new MapUpdater(this);

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
            for (int xAdditive = -Resolution; xAdditive <= Resolution; xAdditive+=Resolution)
            {
                for (int yAdditive = -Resolution; yAdditive <= Resolution; yAdditive+=Resolution)
                {
                    if (x + xAdditive >= 0 && y + yAdditive >= 0 && x + xAdditive < Width*Resolution && y + yAdditive < Height*Resolution && !(xAdditive == 0 && yAdditive == 0))
                    {
                        result.Add(this.Field[(int)((x+xAdditive)/Resolution), (int)((y+yAdditive)/Resolution)]);
                    }
                }
            }
            return result;
        }

        public void colorMap(Graphics graphics)
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Cell currentCell = Field[i, j];
                    currentCell.updateColor();
                    graphics.FillRectangle(new SolidBrush(currentCell.Color), currentCell.X, currentCell.Y, Simulation.resolution, Simulation.resolution);
                }
            }
        }

        public void updatePrevTypes()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Field[i, j].PrevType = Field[i, j].Type;
                }
            }
        }
    }
}
