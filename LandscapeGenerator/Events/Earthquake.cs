using LandscapeGenerator.CellTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.Events
{
    internal class Earthquake: Event
    {
        public override void happen(Cell[,] Field)
        {
            int maxSize = Field.GetLength(0);
            Random random = new Random();

            for ( int i = Math.Max(0, positionX - size); i< Math.Min(maxSize, positionX+size); i++)
            {
                for (int j= Math.Max(0,positionY-size); j< Math.Min(maxSize, positionY+size); j++)
                {
                    int HeightChange = random.Next(-2, 3);
                    if (Field[i, j].Height + HeightChange < 0)
                    {
                        Field[i, j].Height = 0;
                    }
                    else if (Field[i, j].Height + HeightChange > 10)
                    {
                        Field[i, j].Height = 10;
                    }
                    else
                    {
                        Field[i, j].Height += HeightChange;
                    }
                    Field[i, j].Type = TypesContainer.TypeDict[AllTypes.STONE];
                }
            }

        }
    }
}
