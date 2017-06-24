using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8240_Assignment1
{
    /// <summary>
    /// Main class with experiments:
    /// - Aircraft takes off
    /// - Seabird takes off
    /// - Seabird increases speed and flies higher
    /// </summary>
    class Experiment_MakeSeaBirdFly
    {
        static void Main()
        {
            Console.WriteLine("Experiment 1: test the aircraft engine");
            AircraftTakesOff();

            Console.WriteLine("\nExperiment 2: Use the engine in the Seabird");
            IAircraft seabird = SeabirdTakesOff();

            Console.WriteLine("\nExperiment 3: Increase the speed of the Seabird:");
            SeabirdIncreasesRev(seabird);

            Console.WriteLine("Experiments successful; the Seabird flies!");
            Console.ReadKey();
        }

        private static void AircraftTakesOff()
        {
            IAircraft aircraft = new Aircraft();
            Console.WriteLine(aircraft.TakeOff(51));

            if (aircraft.Airborne)
                Console.WriteLine("The aircraft engine is fine, flying at " + aircraft.Height + " meters");
        }

        private static IAircraft SeabirdTakesOff()
        {
            IAircraft seabird = new Seabird();
            Console.WriteLine(seabird.TakeOff(51));
            Console.WriteLine("The Seabird took off");
            return seabird;
        }

        private static void SeabirdIncreasesRev(IAircraft seabird)
        {
            Console.Write((seabird as ISeacraft).IncreaseRevs());
            Console.Write((seabird as ISeacraft).IncreaseRevs());

            if (seabird.Airborne)
                Console.WriteLine("Seabird flying at height " + seabird.Height +
                    " meters and speed " + (seabird as ISeacraft).Speed + " knots");
        }
    }
}
