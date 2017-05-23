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
        public int Height { get; private set; }
        public bool Airbone { get; private set; }

        public Aircraft()
        {
            Height = 0;
            Airbone = false;
        }

        public void TakeOff()
        {
            Console.WriteLine("Aircraft engine takeoff");
            Airbone = true;
            Height = 200; // Meters
        }

    }
}
