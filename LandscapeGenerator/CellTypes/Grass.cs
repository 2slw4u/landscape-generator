using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal class Grass : Type
    {
        private static readonly Dictionary<int, Color> colors = new Dictionary<int, Color>()
        {
            {10, Color.FromArgb(166,208,140)},
            {9, Color.FromArgb(154,202,124)},
            {8, Color.FromArgb(143,196,110)},
            {7, Color.FromArgb(133,191,97)},
            {6, Color.FromArgb(124,186,86)},
            {5, Color.FromArgb(113,177,73)},
            {4, Color.FromArgb(107,168,70)},
            {3, Color.FromArgb(100,157,65)},
            {2, Color.FromArgb(95,149,61)},
            {1, Color.FromArgb(88,139,57)},
            {0, Color.FromArgb(81,128,52)}
        };
        public override Color getColor(int height)
        {
            return colors[height];
        }
        public override bool determineIfSuitable(Cell affectedCell, List<Cell> neighbours)
        {
            if (affectedCell.Type is Grass)
            {
                for (int i = 0; i < neighbours.Count; i++)
                {
                    if (neighbours[i].Type is Forest)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
