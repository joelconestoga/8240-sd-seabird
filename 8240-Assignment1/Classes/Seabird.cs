using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8240_Assignment1
{
    /// <summary>
    /// Seabird represents a bird that can sail and fly, after reaching certain speed.
    /// It inherits sailing abilities from Seacraft and implements the flying abilities
    /// from IAircraft.
    /// </summary>
    public class Seabird : Seacraft, IAircraft
    {
        private const int MIN_HEIGHT = 51;
        private const int MAX_HEIGHT = 400;
        private const int HEIGHT_INCREMENT = 100;
        private const int MIN_SPEED_TO_FLY = 40;

        /// <summary>
        /// Represents the height where the Seabird finds itself
        /// </summary>
        public int Height { get; private set; }

        /// <summary>
        /// Indicate whether the Seabird is flying or landed
        /// </summary>
        public bool Airborne { get { return Height > 50; } }

        /// <summary>
        /// Allows the Seabird to take off and be airborne
        /// </summary>
        /// <param name="meters">Meters define which height should the Seabird go, between 51 and 10000</param>
        /// <returns>Returns a string with the log of the Seabird taking off</returns>
        public string TakeOff(uint meters)
        {
            ValidateHeight(meters);

            string output = "";

            while (!Airborne || Height < meters)
                output += IncreaseRevs();

            return output;
        }

        /// <summary>
        /// Allows the Seabird to increase revs and navigate faster. 
        /// Each call increments the speed by 10 knots.
        /// After 40 knots, the Searbird starts to fly, at 100 meters hight.
        /// Once flying, each call will also increase the height by 100 meters.
        /// </summary>
        /// <returns>Returns a string with the log of the seacraft speed changes</returns>
        public override string IncreaseRevs()
        {
            string output = "";

            output = base.IncreaseRevs() + "\n";

            if (Speed > MIN_SPEED_TO_FLY)
                Height += HEIGHT_INCREMENT;

            return output;
        }

        private static void ValidateHeight(uint meters)
        {
            if (meters < MIN_HEIGHT)
                throw new TooLowException(
                    String.Format("The seabird cannot fly under {0} meters.", MIN_HEIGHT));

            if (meters > MAX_HEIGHT)
                throw new TooHighException(
                    String.Format("The seabird cannot fly over {0} meters.", MAX_HEIGHT));
        }
    }
}
