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
        private const int MIN_HEIGHT = 51;
        private const int MAX_HEIGHT = 10000;
        private const int TAKEOFF_INCREMENT = 10;

        public int Height { get; private set; }
        public bool Airborne { get; private set; }

        public Aircraft()
        {
            Height = 0;
            Airborne = false;
        }

        /// <summary>
        /// Allows the Aircraft to take off and be airborne
        /// </summary>
        /// <param name="meters">Meters define which height should the aircraft go, between 50 and 10000</param>
        /// <returns>Returns a string with the log of the aircraft taking off</returns>
        public string TakeOff(uint meters)
        {
            ValidateHeight(meters);

            string output = IncreaseHeight(meters);

            Airborne = true;

            return output;
        }

        private string IncreaseHeight(uint meters)
        {
            uint dozens = meters / TAKEOFF_INCREMENT;
            int remaining = (int)meters % TAKEOFF_INCREMENT;

            string output = "Aircraft engine takeoff\n";

            for (int i = 0; i < dozens; i++)
            {
                Height += 10;
                output += String.Format("Aircraft height increased to {0} meters\n", Height);
            }

            Height += remaining;
            output += String.Format("Aircraft height increased to {0} meters\n", Height);

            return output;
        }

        private static void ValidateHeight(uint meters)
        {
            if (meters < MIN_HEIGHT)
                throw new TooLowException(
                    String.Format("The aircraft cannot fly under {0} meters.", MIN_HEIGHT));

            if (meters > MAX_HEIGHT)
                throw new TooHighException(
                    String.Format("The aircraft cannot fly over {0} meters.", MAX_HEIGHT));
        }
    }
}
