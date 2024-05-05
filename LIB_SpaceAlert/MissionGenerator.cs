using System;
using System.Collections.Generic;

namespace LIB_SpaceAlert
{
    public class MissionGenerator
    {
        public static Random rnd = new Random();
        public phase[] phases = new phase[3];

        //replace this with weighted picked later!
        private static Event PickRandomEvent()
        {
            int index = rnd.Next(2);
            Event newEvent;
            switch (index)
            {
                case 0:
                    newEvent = new Threat(rnd);
                    break;
                    case 1:
                    newEvent = new IncommingData(rnd);
                    break;
                    default
                    : newEvent = new IncommingData(rnd);
                    break;
            }
            return newEvent;
        }
        public void generatePhases()
        {
            phases[0] = new phase();
            phases[1] = new phase();
            phases[2] = new phase();

            phases[0].events.Add(new IncommingData(rnd, true)); //adding incomming data to start phases

            //generating Length of missions:
            int phase1Duration = rnd.Next(55,55);
            int phase2Duration = rnd.Next(5,13);
            int phase3Duration = rnd.Next(2,5);

            for(int i = 0; i < phase1Duration; i++)
            {
                Event newEvent = PickRandomEvent();
                newEvent.slot = i;
                phases[0].events.Add(newEvent);
            }

        }
        public void printAll()
        {
            foreach (phase phase in phases)
            {
                phase.consolePrinter();
            }
        }
    }
}
