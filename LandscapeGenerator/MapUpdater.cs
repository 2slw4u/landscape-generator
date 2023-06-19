using LandscapeGenerator.CellTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator
{
    internal class MapUpdater
    {
        private LandscapeMap Map;
        private LandscapeMap prevMap;

        public void updateNextTick()
        {

            for (int i = 0; i < Map.Height; i++)
            {
                for (int j = 0; j < Map.Width; ++j)
                {
                    Cell currentCell = Map.Field[i, j];
                    List<Cell> neighbours = Map.getNeighbours(currentCell);
                    foreach(var currentType in TypesContainer.TypeDict)
                    {
                        if (currentType.Value.determineIfSuitable(currentCell, neighbours))
                        {
                            currentCell.Type = currentType.Value;
                            //Map.Simulation.changeText(currentCell.X.ToString() + " " + currentCell.Y.ToString() + "   ");
                            break;
                        }
 
                    }
                }
            }
        }
        public MapUpdater(LandscapeMap Map)
        {
            this.Map = Map;
            this.prevMap = Map;
        }
    }
}
