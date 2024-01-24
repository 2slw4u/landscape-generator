using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal static class TypeFactory
    {
        public static Type getType(AllTypes type)
        {
            switch(type)
            {
                case AllTypes.LAVA:
                    return new Lava();
                case AllTypes.FOREST:
                    return new Forest();
                case AllTypes.WATER:
                    return new Water();
                case AllTypes.GRASS: 
                    return new Grass();
                case AllTypes.SAND:
                    return new Sand();
                case AllTypes.SNOW:
                    return new Snow();
                default:
                    return new Stone();
            }
        }
    }
}
