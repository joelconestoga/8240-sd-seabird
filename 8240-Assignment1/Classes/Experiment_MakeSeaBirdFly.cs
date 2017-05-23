using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8240_Assignment1
{
    class Experiment_MakeSeaBirdFly
    {
        static void Main()
        {
            // No adapter
            Console.WriteLine("Experiment 1: test the aircraft engine");

            IAircraft aircraft = new Aircraft();
            aircraft.TakeOff();

            if (aircraft.Airbone)
                Console.WriteLine("The aircraft engine is fine, flying at " + aircraft.Height + " meters");

            // Classic usage of an adapter
            Console.WriteLine("\nExperiment 2: Use the engine in the Seabird");
            IAircraft seabird = new Seabird();
            seabird.TakeOff(); // And automatically increases speed
            Console.WriteLine("The Seabird took off");

            // Two-way adapter: using seacraft instructions on an IAircraft object
            // (where they are not in the IAircraft interface)
            Console.WriteLine("\nExperiment 3: Increase the speed of the Seabird:");
            (seabird as ISeacraft).IncreaseRevs();
            (seabird as ISeacraft).IncreaseRevs();

            if (seabird.Airbone)
                Console.WriteLine("Seabird flying at height " + seabird.Height +
                    " meters and speed " + (seabird as ISeacraft).Speed + " knots");

            Console.WriteLine("Experiments successful; the Seabird flies!");

            Console.ReadKey();
        }
    }
}
