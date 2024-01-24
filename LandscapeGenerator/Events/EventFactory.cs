using LandscapeGenerator.CellTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.Events
{
    internal class EventFactory
    {
        public static Event getEvent(AllEvents type)
        {
            switch (type)
            {
                case AllEvents.DRAUGHT:
                    return new Draught();
                case AllEvents.EARTHQUAKE:
                    return new Earthquake();
                case AllEvents.VOLCANO:
                    return new Volcano();
                default:
                    return new Earthquake();

            }
        }
    }
}
