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
            //сделать нормальный Game of Life
            Random random = new Random();
            for (int i = 0; i < neighbours.Count; i++)
            {
                if (neighbours[i].type is Forest && random.Next(0, 10) >= 5)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
