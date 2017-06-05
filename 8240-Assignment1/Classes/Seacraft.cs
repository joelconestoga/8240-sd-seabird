using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8240_Assignment1
{
    // Adaptee implementation
    public class Seacraft : ISeacraft
    {
        public int Speed { get; private set; }

        public Seacraft()
        {
            Speed = 0;
        }

        public virtual void IncreaseRevs()
        {
            Speed += 10;

            /* Notes from class:
             * - return value instead of writing to console
             */
            Console.WriteLine("Seacraft engine increases revs to " + Speed + " knots");
        }

        public string IncreaseRevsNew()
        {
            Speed += 10;
            return "Seacraft engine increases revs to " + Speed + " knots";
        }
    }
}
