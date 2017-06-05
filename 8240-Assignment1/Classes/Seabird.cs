using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8240_Assignment1
{
    // Adapter
    class Seabird : Seacraft, IAircraft
    {
        public int Height { get; private set; }

        public bool Airborne { get { return Height > 50; } }

        // A two-way adapter hides and routes the Target's methods
        // Use Seacraft instructions to implement this one
        public void TakeOff()
        {
            while (!Airborne)
                IncreaseRevs();
        }

        // This method is common to both Target and Adaptee
        public override void IncreaseRevs()
        {
            base.IncreaseRevs();
            if (Speed > 40)
                Height += 100;
        }

        public string TakeOff(uint meters)
        {
            throw new NotImplementedException();
        }
    }
}
