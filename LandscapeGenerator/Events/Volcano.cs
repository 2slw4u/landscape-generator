using LandscapeGenerator.CellTypes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.Events
{
    internal class Volcano : Event
    {
        public override void happen(Cell[,] Field)
        {
            int maxSize = Field.GetLength(0);
            Random random = new Random();

            for (int i = Math.Max(0, positionX - size/2); i < Math.Min(maxSize, positionX + size/2); i++)
            {
                for (int j = Math.Max(0, positionY - size/2); j < Math.Min(maxSize, positionY + size/2); j++)
                {
                    int HeightChange = random.Next(-3, 0);
                    if (Field[i, j].Height + HeightChange > 10)
                    {
                        Field[i, j].Height = 10;
                    }
                    else if (Field[i, j].Height + HeightChange < 0)
                    {
                        Field[i, j].Height = 0;
                    }
                    else
                    {
                        Field[i, j].Height += HeightChange;
                    }
                    Field[i, j].Type = TypesContainer.TypeDict[AllTypes.STONE];
                }
            }
            Field[positionX, positionY].PrevType = TypesContainer.TypeDict[AllTypes.LAVA];
            Field[positionX, positionY].Type = TypesContainer.TypeDict[AllTypes.LAVA];

        }
    }
}
