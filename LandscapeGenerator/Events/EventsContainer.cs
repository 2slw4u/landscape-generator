using LandscapeGenerator.CellTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.Events
{
    internal static class EventsContainer
    {
        public static Dictionary<Events.AllEvents, Events.Event> EventsDict;
        public static void initialize()
        {
            EventsDict = new Dictionary<AllEvents, Events.Event>();
            foreach (AllEvents eventName in Enum.GetValues(typeof(AllEvents)))
            {
                EventsDict.Add(eventName, EventFactory.getEvent(eventName));
            }
        }
    }
}
