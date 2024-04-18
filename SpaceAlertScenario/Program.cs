using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LIB_SpaceAlert;

namespace SpaceAlertScenario
{
    internal partial class Program
    {


        public static void Main(string[] args)
        {
            MissionGenerator mg = new MissionGenerator();
            mg.generatePhases();
            mg.printAll();
            Console.ReadKey();
        }
    }
}
