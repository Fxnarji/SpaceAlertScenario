using System;
using System.Collections.Generic;

namespace LIB_SpaceAlert
{
    public partial class phase
    {
        public List<Event> events = new List<Event>(); 
        public void consolePrinter()
        {
            foreach(Event e in events)
            {
                switch (e.color)
                {
                    case (Event.Color.Red):
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;

                    case (Event.Color.Internal):
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    case (Event.Color.Blue):
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;

                    case (Event.Color.Green):
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                    case (Event.Color.Yellow):
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;



                }
                Console.WriteLine(e.toString());
            }
        }
    }
}
