using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8240_Assignment1
{
    // ITarget interface
    interface IAircraft
    {
        bool Airborne { get; }

        int Height { get; }

        void TakeOff();

        string TakeOff(uint meters);
    }
}
