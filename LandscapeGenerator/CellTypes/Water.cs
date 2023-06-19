using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal class Water : Type
    {
        public override bool determineIfSuitable(Cell affectedCell, List<Cell> neighbours)
        {
            for (int i = 0; i < neighbours.Count; i++)
            {
                if (neighbours[i].type is Water && neighbours[i].Height >= affectedCell.Height)
                {
                    //здесь докинуть нормальный updateSourceHeight()
                    return true;
                }
            }
            return false;
        }
        
    }
}
