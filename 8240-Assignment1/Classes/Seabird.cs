using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8240_Assignment1
{
    public class Seabird : Seacraft, IAircraft
    {
        private const int MIN_HEIGHT = 51;
        private const int MAX_HEIGHT = 10000;
        private const int HEIGHT_INCREMENT = 100;

        public int Height { get; private set; }

        public bool Airborne { get { return Height > 50; } }

        public string TakeOff(uint meters)
        {
            ValidateHeight(meters);

            string output = "";

            while (!Airborne && Height < meters)
                output += IncreaseRevs();

            return output;
        }

        public override string IncreaseRevs()
        {
            string output = "";

            output = base.IncreaseRevs() + "\n";

            if (Speed > 40)
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
