using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal class Stone : Type
    {
        public override bool determineIfSuitable(Cell affectedCell, List<Cell> neighbours)
        {
            return true;
        }
        public override void update(Type newType)
        {

        }
    }
}
