using System.Runtime.InteropServices;

namespace LIB_SpaceAlert
{
    public class Threat : Event
    {
        public int offset;
        public enum Zone
        {
            blue,
            white,
            red,
            intern
        }

        public enum status
        {
            unconfirmed,
            confirmed,
            serious
        }
    }
}
