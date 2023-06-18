using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal class Grass : Type
    {
        public override bool determineIfSuitable(Cell affectedCell, List<Cell> neighbours)
        {
            if (affectedCell.type is Grass)
            {
                for (int i = 0; i < neighbours.Count; i++)
                {
                    if (neighbours[i].type is Forest)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public override void update(Type newType)
        {

        }
    }
}
