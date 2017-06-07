using _8240_Assignment1;
using NUnit.Framework;
using System;

namespace _8240_Assignment1_NUnitTests
{
    [TestFixture]
    public class AircraftTest
    {
        Aircraft aircraft;

        /// <summary>
        /// Instantiate the subject under test
        /// </summary>
        [SetUp]
        public void Setup()
        {
            aircraft = new Aircraft();
        }

        /// <summary>
        /// Tests object initialization
        /// </summary>
        [Test]
        public void Aircraft_DefaultConstructor_HeightZeroAirborneFalse()
        {
            Assert.AreEqual(aircraft.Height, 0);
            Assert.IsFalse(aircraft.Airborne);
        }

        /// <summary>
        /// Tests the minimum height to take off
        /// </summary>
        [Test]
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

        /// <summary>
        /// Tests taking off with a height smaller than the minimum of 51 meters
        /// </summary>
        [Test]
        public void Aircraft_TakeOff50Meters_ReturnsException()
        {
            MyAssert.AssertThrows<TooLowException>(() => aircraft.TakeOff(50),
                "The aircraft cannot fly under 51 meters.");
        }

        /// <summary>
        /// Tests taking off with a height larger than the maximum of 10000 meters
        /// </summary>
        [Test]
        public void Aircraft_TakeOff10001Meters_ReturnsException()
        {
            MyAssert.AssertThrows<TooHighException>(() => aircraft.TakeOff(10001),
                "The aircraft cannot fly over 10000 meters.");
        }
    }
}
