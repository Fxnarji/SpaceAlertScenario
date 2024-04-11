using System;
using System.Text;
using System.Threading.Tasks;
using LIB_SpaceAlert;

namespace SpaceAlertScenario
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            NormalMode mode = new NormalMode();

            Mission mission = new Mission();

            mission = mode.Generate();

            mission.Print();
        }
    }
}
