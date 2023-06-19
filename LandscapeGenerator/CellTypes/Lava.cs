using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.CellTypes
{
    internal class Lava : Type
    {
        private static readonly Dictionary<int, Color> colors = new Dictionary<int, Color>()
        {
            {10, Color.FromArgb(255, 0, 0)},
            {9, Color.FromArgb(255, 0, 0)},
            {8, Color.FromArgb(255, 0, 0)},
            {7, Color.FromArgb(255, 0, 0)},
            {6, Color.FromArgb(255, 0, 0)},
            {5, Color.FromArgb(255, 0, 0)},
            {4, Color.FromArgb(225, 0, 0)},
            {3, Color.FromArgb(195, 0, 0)},
            {2, Color.FromArgb(165, 0, 0)},
            {1, Color.FromArgb(135, 0, 0)},
            {0, Color.FromArgb(105, 0, 0)}


        };
        public override Color getColor(int height)
        {
            return colors[height];
        }

        public override bool determineIfSuitable(Cell affectedCell, List<Cell> neighbours)
        {
            if (affectedCell.PrevType is Lava)
            {
                bool waterClose = false;
                foreach(var cell in neighbours)
                {
                    if (cell.PrevType is Water || cell.Type is Water)
                    {
                        waterClose = true;
                        break;
                    }
                    if (cell.PrevType is Forest || cell.Type is Forest)
                    {
                        cell.Type = TypesContainer.TypeDict[AllTypes.STONE];
                    }
                }
                if (waterClose)
                {
                    affectedCell.Type = TypesContainer.TypeDict[AllTypes.STONE];
                    foreach(var cell in neighbours)
                    {
                        cell.PrevType = TypesContainer.TypeDict[AllTypes.STONE];
                        cell.Type = TypesContainer.TypeDict[AllTypes.STONE];
                    }
                    affectedCell.Height = Math.Min(affectedCell.Height + 2, 10);
                    return false;
                }
                return true;
            }
            for (int i = 0; i < neighbours.Count; i++)
            {
                if (neighbours[i].PrevType is Lava && neighbours[i].Height >= affectedCell.Height)
                {
                    return true;
                }
            }
            return false;
        }
        public override void Initialize(Cell[,] Field)
        {

        }
    }
}
