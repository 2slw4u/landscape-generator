using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal class Sand : Type
    {
        private static readonly Dictionary<int, Color> colors = new Dictionary<int, Color>()
        {
            {10, Color.FromArgb(233, 224, 207)},
            {9, Color.FromArgb(226, 214, 192)},
            {8, Color.FromArgb(220, 205, 178)},
            {7, Color.FromArgb(213, 195, 163)},
            {6, Color.FromArgb(207, 186, 149)},
            {5, Color.FromArgb(203, 180, 139)},
            {4, Color.FromArgb(198, 173, 128)},
            {3, Color.FromArgb(191, 162, 111)},
            {2, Color.FromArgb(184, 153, 96)},
            {1, Color.FromArgb(178, 144, 82)},
            {0, Color.FromArgb(165, 132, 73)}

        };
        public override Color getColor(int height)
        {
            return colors[height];
        }
        public override bool determineIfSuitable(Cell affectedCell, List<Cell> neighbours)
        {
            for (int i = 0; i < neighbours.Count; i++)
            {
                if (neighbours[i].Type is Water)
                {
                    return true;
                }
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
