using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal class Forest : Type
    {
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
