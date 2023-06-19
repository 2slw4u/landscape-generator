using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal abstract class Type
    {
        public abstract bool determineIfSuitable(Cell affectedCell, List<Cell> neighbours);

        public abstract Color getColor(int height);
    }
}
