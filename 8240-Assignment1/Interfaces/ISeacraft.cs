using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8240_Assignment1
{
    /// <summary>
    /// Represents a device that can sail
    /// </summary>
    interface ISeacraft
    {
        int Speed { get; }
        string IncreaseRevs();
    }
}
