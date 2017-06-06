using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8240_Assignment1
{
    /// <summary>
    /// Seacraft represents a sailing device, which main functionality is to increase speed, 
    /// by increasing revs
    /// </summary>
    public class Seacraft : ISeacraft
    {
        private const int REVS_INCREMENT = 10;

        /// <summary>
        /// Represents the how fast the Seacraft is navigating
        /// </summary>
        public int Speed { get; private set; }

        /// <summary>
        /// Default constructor, wich also set up the initial speed value
        /// </summary>
        public Seacraft()
        {
            Speed = 0;
        }

        /// <summary>
        /// Allows the Seacraft to increase revs and navigate faster. Each call increments the speed by 10 knots
        /// </summary>
        /// <returns>Returns a string with the log of the seacraft speed changes</returns>
        public virtual string IncreaseRevs()
        {
            Speed += REVS_INCREMENT;
            return "Seacraft engine increases revs to " + Speed + " knots";
        }
    }
}
