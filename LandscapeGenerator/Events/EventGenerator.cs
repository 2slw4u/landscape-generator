using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGenerator.Events
{
    internal class EventGenerator
    {
        public double EventChance { get; private set; }

        public Event GenerateEvent(int sizeMap)
        {
            
            Random random = new Random();
            int eventsType = random.Next(0, EventsContainer.EventsDict.Count);
            if (random.NextDouble() > EventChance)
            {
                Event newEvent = EventFactory.getEvent(EventsContainer.EventsDict.ElementAt(eventsType).Key);
                newEvent.size = random.Next(5,15);
                //newEvent.duration = random.Next();
                newEvent.positionX = random.Next(0, sizeMap);
                newEvent.positionY = random.Next(0, sizeMap);
                return newEvent;
            }
            else return null;
        }
        public EventGenerator(double chance) 
        {
            EventChance = chance;
        }
    }
}
