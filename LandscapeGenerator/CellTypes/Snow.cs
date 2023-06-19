using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal class Snow : Type
    {
        public override bool determineIfSuitable(Cell affectedCell, List<Cell> neighbours)
        {
            Random random = new Random();
            if (random.Next(0, 9) + affectedCell.Height >= 10)
            {
                return true;
            }
            return false;
        }
        public override void update(Type newType)
        {

        }
    }
}
