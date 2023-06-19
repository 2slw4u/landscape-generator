using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal class Forest : Type
    {
        private static readonly Dictionary<int, Color> colors = new Dictionary<int, Color>()
        {
           {10, Color.FromArgb(84, 134, 54)},
            {9, Color.FromArgb(77, 123, 49)},
            {8, Color.FromArgb(67, 107, 43)},
            {7, Color.FromArgb(60, 96, 38)},
            {6, Color.FromArgb(57, 90, 36)},
            {5, Color.FromArgb(50, 80, 32)},
            {4, Color.FromArgb(43, 69, 27)},
            {3, Color.FromArgb(41, 66, 26)},
            {2, Color.FromArgb(31, 52, 20)},
            {1, Color.FromArgb(27, 45, 17)},
            {0, Color.FromArgb(24, 43, 15)}

        };
        public override Color getColor(int height)
        {
            return colors[height];
        }
        public override bool determineIfSuitable(Cell affectedCell, List<Cell> neighbours)
        {
            int forestCount = 0;
            foreach(Cell neighbor in neighbours)
            {
                if(neighbor.Type is Forest)
                {
                    forestCount++;
                }
            }
            if ((forestCount == 2 || forestCount == 3) && affectedCell.Type is Forest)
            {
                return true;
            }
            if (forestCount == 3)
            {
                return true;
            }

            return false;
        }

        private static readonly Dictionary<int, Color> colors = new Dictionary<int, Color>()
        {
            {4, Color.FromArgb(255, 120,184,80)},
            {5, Color.FromArgb(255, 98,155,63)}
        };
        public override Color getColor(int height)
        {
            return colors[height];
        }

    }
}
