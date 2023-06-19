using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal class Stone : Type
    {
        private static readonly Dictionary<int, Color> colors = new Dictionary<int, Color>()
        {
            {10, Color.FromArgb(185, 173, 157)},
            {9, Color.FromArgb(177, 163, 145)},
            {8, Color.FromArgb(166, 151, 130)},
            {7, Color.FromArgb(158, 141, 118)},
            {6, Color.FromArgb(150, 131, 106)},
            {5, Color.FromArgb(137, 120, 97)},
            {4, Color.FromArgb(123, 108, 87)},
            {3, Color.FromArgb(113, 98, 79)},
            {2, Color.FromArgb(95, 82, 67)},
            {1, Color.FromArgb(83, 72, 59)},
            {0, Color.FromArgb(65, 57, 47)}

        };
        public override Color getColor(int height)
        {
            return colors[height];
        }
        public override bool determineIfSuitable(Cell affectedCell, List<Cell> neighbours)
        {
            return false;
        }
    }
}
