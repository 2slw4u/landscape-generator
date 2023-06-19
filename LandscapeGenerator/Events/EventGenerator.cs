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


        public Event GenerateEvent(int sizeMap, int xCoordinate, int yCoordinate, int index, double randomChance)
        {
            
            Random random = new Random();
            if (randomChance > EventChance)
            {
                Event newEvent = EventFactory.getEvent(EventsContainer.EventsDict.ElementAt(index).Key);
                newEvent.size = random.Next(5,15);
                newEvent.positionX = xCoordinate;
                newEvent.positionY = yCoordinate;
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
