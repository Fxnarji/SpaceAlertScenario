using System.Collections.Generic;
using System.Diagnostics;

namespace LIB_SpaceAlert
{
    public class NormalMode : MissionGenerator
    {

        public List<Event> Threads = new List<Event>
        {
            
        };

        public override Mission Generate()
        {
            return new Mission();
        }
    }
}
