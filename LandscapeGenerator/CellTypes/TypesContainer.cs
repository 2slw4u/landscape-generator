using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal static class TypesContainer
    {
        public static Dictionary<CellTypes.AllTypes,CellTypes.Type> TypeDict;
        public static void initialize()
        {
            TypeDict = new Dictionary<AllTypes, CellTypes.Type>();
            foreach (AllTypes typeName in Enum.GetValues(typeof(AllTypes)))
            {
                TypeDict.Add(typeName, TypeFactory.getType(typeName));
            }
        }
    }
}
