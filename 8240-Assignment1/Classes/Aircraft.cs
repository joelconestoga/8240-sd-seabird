using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8240_Assignment1
{
    // Target
    public sealed class Aircraft : IAircraft
    {
        public int Height { get; private set; }
        public bool Airbone { get; private set; }

        public Aircraft()
        {
            Height = 0;
            Airbone = false;
        }

        /* Notes from class:
         * - add new parameter Height
         * - add comment explaining which Unit the parameter represents
         * - use Unsigned Integral Type and validate max/min value
         */
        public void TakeOff()
        {

            /* Notes from class:
             * - return value instead of writing to console
             */
            Console.WriteLine("Aircraft engine takeoff");
            Airbone = true;
            Height = 200; // Meters
        }

    }
}
