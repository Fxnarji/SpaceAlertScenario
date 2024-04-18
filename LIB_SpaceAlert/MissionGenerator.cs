using System.Collections.Generic;

namespace LIB_SpaceAlert
{
    public class MissionGenerator
    {
        public phase[] phases = new phase[3];
        public void generatePhases()
        {
            phases[0] = new phase();
            phases[1] = new phase();
            phases[2] = new phase();

            phases[0].events.Add(new IncommingData()); //adding incomming data to start phases

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
