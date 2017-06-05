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
        private const int MIN_HEIGHT = 20;
        private const int MAX_HEIGHT = 10000;

        public int Height { get; private set; }
        public bool Airborne { get; private set; }

        public Aircraft()
        {
            Height = 0;
            Airborne = false;
        }

        public void TakeOff()
        {
            throw new NotImplementedException("DELETE THIS METHOD");
        }

        /// <summary>
        /// Allows the Aircraft to take off be airborne
        /// </summary>
        /// <param name="meters">Meters define which height should the aircraft go, between 20 and 10000</param>
        /// <returns>Returns a string with the log of the aircraft taking off</returns>
        public string TakeOff(uint meters)
        {
            ValidateHeight(meters);

            string output = "Aircraft engine takeoff\n";

            while (Height < meters)
            {
                Height += 10;
                output += String.Format("Aircraft height increased to {0} meters\n", Height);
            }

            Airborne = true;

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
