using System;

namespace LIB_SpaceAlert
{
    public class Threat : Event
    {

        public Threat(Random rnd)
        {
            int index = rnd.Next(3);
            color = (Color)index;
            text = "new ";
            string[] threats = new string[] {
                "unconfirmed",
                "internal",
                "serious",
                ""
            };

            text += threats[index];
            text += " threat detected!";
            //give random Freedom color from red, blue, white
        }

        public void randomize()
        {

        }
    }
}
