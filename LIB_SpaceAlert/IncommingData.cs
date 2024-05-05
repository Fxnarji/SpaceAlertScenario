using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_SpaceAlert
{
    public class IncommingData : Event
    {
        
        public IncommingData(Random rnd, bool incomming = false)
        {
            string[] variants = new string[]
            {
                "incomming data...",
                "communication lost",
                "communication restored",
                "data transfer"
            };
            text = variants[rnd.Next(variants.Length)];
            color = Color.Yellow;
            slot = 0;

            if (incomming)
            {
                text = "incomming data...";
            }
        }
    }
}
