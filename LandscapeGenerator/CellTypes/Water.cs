using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal class Water : Type
    {
        private static readonly Dictionary<int, Color> colors = new Dictionary<int, Color>()
        {
            {10, Color.FromArgb(205, 217, 239)},
            {9, Color.FromArgb(188, 204, 234)},
            {8, Color.FromArgb(173, 193, 229)},
            {7, Color.FromArgb(159, 183, 225)},
            {6, Color.FromArgb(144, 171, 220)},
            {5, Color.FromArgb(130, 161, 216)},
            {4, Color.FromArgb(106, 142, 208)},
            {3, Color.FromArgb(86, 127, 202)},
            {2, Color.FromArgb(60, 106, 190)},
            {1, Color.FromArgb(50, 89, 158)},
            {0, Color.FromArgb(42, 75, 134)}


        };
        public override Color getColor(int height)
        {
            return colors[height];
        }

        public override bool determineIfSuitable(Cell affectedCell, List<Cell> neighbours)
        {
            for (int i = 0; i < neighbours.Count; i++)
            {
                if (neighbours[i].Type is Water && neighbours[i].Height >= affectedCell.Height)
                {
                    //здесь докинуть нормальный updateSourceHeight()
                    return true;
                }
            }
            return false;
        }

    }
}
