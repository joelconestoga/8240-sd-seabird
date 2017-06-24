using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8240_Assignment1
{
    /// <summary>
    /// Represents a device that can fly
    /// </summary>
    interface IAircraft
    {
        bool Airborne { get; }

        int Height { get; }

        string TakeOff(uint meters);
    }

    /// <summary>
    /// Represents a device that can sail
    /// </summary>
    interface ISeacraft
    {
        int Speed { get; }
        string IncreaseRevs();
    }
}
