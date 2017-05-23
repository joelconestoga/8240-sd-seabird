using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _8240_Assignment1_Tests
{
    [TestClass]
    public class AircraftTests
    {
        [TestMethod]
        public void CreateAircraft()
        {
            // assert Height and Airbone
        }

        [TestMethod]
        public void TakeOffWithValidHeight()
        {
            // call TakeOff with reasonable height
            // assert string/value returned
        }

        [TestMethod]
        public void TakeOffWithInvalidHeight()
        {
            // call TakeOff with negative value
            // call TakeOff with very high value
        }
    }
}
