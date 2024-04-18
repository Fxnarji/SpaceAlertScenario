using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_SpaceAlert
{
    public class IncommingData : Event
    {
        

        public IncommingData()
        {
            Random rnd  = new Random();
            text = "incomming data...";
            color = Color.White;
            slot = 0;
        }
    }
}
