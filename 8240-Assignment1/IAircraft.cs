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
        bool Airbone { get; }
        void TakeOff();
        int Height { get; }
    }
}
