using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _8240_Assignment1;

namespace _8240_Assignment1_Tests
{
    [TestClass]
    public class AircraftTests
    {
        Aircraft aircraft;

        [TestInitialize]
        public void Setup()
        {
            aircraft = new Aircraft();
        }

        [TestMethod]
        public void Aircraft_DefaultConstructor_HeightZeroAirborneFalse()
        {
            Assert.AreEqual(aircraft.Height, 0);
            Assert.IsFalse(aircraft.Airborne);
        }

        [TestMethod]
        public void Aircraft_TakeOff51Meters_AirborneTrue()
        {
            string output = aircraft.TakeOff(51);

            Assert.AreEqual(output,
                "Aircraft engine takeoff\n" +
                "Aircraft height increased to 10 meters\n" +
                "Aircraft height increased to 20 meters\n" +
                "Aircraft height increased to 30 meters\n" +
                "Aircraft height increased to 40 meters\n" +
                "Aircraft height increased to 50 meters\n" +
                "Aircraft height increased to 51 meters\n");

            Assert.IsTrue(aircraft.Airborne);
        }

        [TestMethod]
        public void Aircraft_TakeOff50Meters_ReturnsException()
        {
            MyAssert.AssertThrows<TooLowException>(() => aircraft.TakeOff(50),
                "The aircraft cannot fly under 51 meters.");
        }

        [TestMethod]
        public void Aircraft_TakeOff10001Meters_ReturnsException()
        {
            MyAssert.AssertThrows<TooHighException>(() => aircraft.TakeOff(10001),
                "The aircraft cannot fly over 10000 meters.");
        }
    }
}
