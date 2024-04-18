using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Schema;

namespace LIB_SpaceAlert
{
    public abstract class Event
    {
        public int slot;
        public int length = 1;
        public enum Color
        {
            Red,
            Blue,
            White,
            Green,
            Internal
        }

        public Color color = new Color();

        public string text;
        public string toString()
        {
            return slot + " " + text + " " + color;
        }
    }
}
