using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal static class TypesContainer
    {
        public static List<CellTypes.Type> TypeList;
        public static void initialize()
        {
            TypeList = new List<CellTypes.Type>();
            foreach (AllTypes typeName in Enum.GetValues(typeof(AllTypes)))
            {
                TypeList.Add(TypeFactory.getType(typeName));
            }
        }
    }
}
