using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.Events
{
    internal abstract class Event
    {
        public int positionX { get;  set; }
        public int positionY { get;  set; }
        public int size { get;  set; }
        public int duration { get; set; }

        public abstract void happen(Cell[,] Field);
    }
}
