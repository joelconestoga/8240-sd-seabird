using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8240_Assignment1
{
    // Target
    class Aircraft : IAircraft
    {
        int height;
        bool airbone;

        public Aircraft()
        {
            height = 0;
            airbone = false;
        }

        public void TakeOff()
        {
            Console.WriteLine("Aircraft engine takeoff");
            airbone = true;
            height = 200; // Meters
        }

        public bool Airbone
        {
            get { return airbone; }
        }

        public int Height
        {
            get { return height; }
        }

    }
}
