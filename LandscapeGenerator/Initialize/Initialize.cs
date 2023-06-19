using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.Initialize
{
    internal class Initialize
    {
        private Form1 Form1;

        public LandscapeMap InitializeMap()
        {

            LandscapeMap map = new LandscapeMap(Form1.cellsAmount, Form1.cellsAmount, Form1);
            for (int i = 0; i < Form1.cellsAmount; ++i)
            {
                for (int j = 0; j <  Form1.cellsAmount; ++j)
                {
                    map.Field[i, j] = new Cell(i * Form1.resolution, j * Form1.resolution);
                }
            }
            MapGenerator generator = new DiamondSquareGenerator();
            map.Field = generator.generateHeightMap(map.Field);
            return map;
        }

        public Initialize(Form1 form)
        {
            Form1 = form;
        }

    }
}
