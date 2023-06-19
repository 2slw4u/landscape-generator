using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal class Snow : Type
    {
        private static readonly Dictionary<int, Color> colors = new Dictionary<int, Color>()
        {
            {10, Color.FromArgb(255, 255, 255)},
            {9, Color.FromArgb(249, 249, 249)},
            {8, Color.FromArgb(238, 238, 238)},
            {7, Color.FromArgb(228, 228, 228)},
            {6, Color.FromArgb(217, 217, 217)},
            {5, Color.FromArgb(209, 209, 209)},
            {4, Color.FromArgb(197, 197, 197)},
            {3, Color.FromArgb(188, 188, 188)},
            {2, Color.FromArgb(180, 180, 180)},
            {1, Color.FromArgb(171, 171, 171)},
            {0, Color.FromArgb(163, 163, 163)}
        };
        public override Color getColor(int height)
        {
            return colors[height];
        }
        public override bool determineIfSuitable(Cell affectedCell, List<Cell> neighbours)
        {
            Random random = new Random();
            if (random.Next(0, 900) + affectedCell.Height*100 >= 1600)
            {
                return true;
            }
            return false;
        }
    }
}
