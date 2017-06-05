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
        private const int REVS_INCREMENT = 10;

        public int Speed { get; private set; }

        public Seacraft()
        {
            Speed = 0;
        }

        public virtual string IncreaseRevs()
        {
            Speed += REVS_INCREMENT;
            return "Seacraft engine increases revs to " + Speed + " knots";
        }
    }
}
