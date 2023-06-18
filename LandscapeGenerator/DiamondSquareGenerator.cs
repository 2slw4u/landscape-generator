using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel.Design;

namespace LandscapeGenerator
{
    internal class DiamondSquareGenerator : MapGenerator
    {
        private double seed { get; set; }
        private double roughness { get; set; }
        public Cell[,] generateHeightMap(Cell[,] field)
        {
            const double SEED = 0.35;
            const double ROUGHNESS = 1.0;
            int size = field.GetLength(0);
            int pow2Size = (int) Math.Pow(2, Math.Ceiling(Math.Log2(size)));

            double[,] data = diamondSquareAlgorithm(pow2Size, ROUGHNESS, SEED);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    data[i, j] += 0.5;
                    if (data[i, j] > 1.0)
                    {
                        data[i, j] = 1.0;
                    }
                    if (data[i, j] < 0.0)
                    {
                        data[i, j] = 0.0;
                    }
                    field[i, j].Height = doubleToHeight(data[i, j]);
                }
            }

            return field;
        }

        private int doubleToHeight(double d)
        {
            const int MAXHEIGHT = 9;
            int h = (int) Math.Floor(d * (MAXHEIGHT + 1));
            return h;
        }

        private double[,] diamondSquareAlgorithm(int size, double roughness, double seed)
        {
            Debug.Assert(size % 2 == 0);
            size++;

            double[,] data = new double[size, size];
            data[0, 0] = data[0, size - 1] = data[size - 1, 0] = data[size - 1, size - 1] = seed;

            double h = roughness;//the range (-h -> +h) for the average offset - affects roughness
            Random r = new Random();

            for (int sideLength = size - 1; sideLength >= 2; sideLength /= 2, h /= 2.0)
            {
                int halfSide = sideLength / 2;

                for (int x = 0; x < size - 1; x += sideLength)
                {
                    for (int y = 0; y < size - 1; y += sideLength)
                    {
                        double avg = data[x, y] + //top left
                        data[x + sideLength, y] +//top right
                        data[x, y + sideLength] + //lower left
                        data[x + sideLength, y + sideLength];//lower right
                        avg /= 4.0;

                        data[x + halfSide, y + halfSide] = avg + (r.NextDouble() * 2 * h) - h;
                    }
                }

                for (int x = 0; x < size; x += halfSide)
                {
                    for (int y = (x + halfSide) % sideLength; y < size; y += sideLength)
                    {
                        double avg =
                          data[(x - halfSide + size) % size, y] + //left of center
                          data[(x + halfSide) % size, y] + //right of center
                          data[x, (y + halfSide) % size] + //below center
                          data[x, (y - halfSide + size) % size]; //above center
                        avg /= 4.0;

                        avg = avg + (r.NextDouble() * 2 * h) - h;
                        data[x, y] = avg;
                    }
                }
            }
            return data;
        }
    }

}
