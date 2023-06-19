using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal class Sand : Type
    {
        public override bool determineIfSuitable(Cell affectedCell, List<Cell> neighbours)
        {
            for (int i = 0; i < neighbours.Count; i++)
            {
                if (neighbours[i].type is Water)
                {
                    return true;
                }
            }
            return false;
        }
        public override void update(Type newType)
        {

        }
    }
}
