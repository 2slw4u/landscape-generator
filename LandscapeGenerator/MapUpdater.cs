using LandscapeGenerator.CellTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator
{
    internal class MapUpdater
    {
        private LandscapeMap Map;
        private TypeFactory TypeFactory;
        private List<CellTypes.Type> TypeList;

        public void updateNextTick()
        {

            for (int i = 0; i < Map.Height; i++)
            {
                for (int j = 0; j < Map.Width; ++j)
                {
                    List<Cell> neighbours = Map.getNeighbours(Map.Field[i, j]);
                    foreach(CellTypes.Type currentType in TypeList)
                    {
                        currentType.determineIfSuitable(Map.Field[i, j], neighbours);
                    }
                }
            }
        }
        public MapUpdater(LandscapeMap Map)
        {
            this.Map = Map;
            this.TypeFactory = new TypeFactory();
            TypeList = new List<CellTypes.Type>();
            foreach (AllTypes typeName in Enum.GetValues(typeof(AllTypes)))
            {
                TypeList.Add(TypeFactory.getType(typeName));
            }

        }
    }
}
