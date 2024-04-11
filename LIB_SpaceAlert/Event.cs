using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_SpaceAlert
{

    public abstract class Event
    {
        private int time
        {  get; set; }

        public enum color
        {
            white,
            pink,
            red,
            yellow,
            blue,
            green,
            grey
        }

        private string text
        { get; set; }
    }
}
