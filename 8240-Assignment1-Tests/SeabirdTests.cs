using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _8240_Assignment1;

namespace _8240_Assignment1_Tests
{
    [TestClass]
    public class SeabirdTests
    {
        Seabird seabird;

        [TestInitialize]
        public void Setup()
        {
            seabird = new Seabird();
        }

        [TestMethod]
        public void Seabird_DefaultConstructor_HeightZeroAirborneFalse()
        {
            Assert.AreEqual(seabird.Speed, 0);
            Assert.IsFalse(seabird.Airborne);
        }

        [TestMethod]
        public void Seabird_IncreaseRevs40_Speed40AirborneFalse()
        {
            Assert.AreEqual(seabird.IncreaseRevs(), 
                "Seacraft engine increases revs to 10 knots\n");

            Assert.AreEqual(seabird.Speed, 10);
            Assert.IsFalse(seabird.Airborne);

            seabird.IncreaseRevs();
            seabird.IncreaseRevs();
            
            Assert.AreEqual(seabird.IncreaseRevs(),
                "Seacraft engine increases revs to 40 knots\n");

            Assert.AreEqual(seabird.Speed, 40);
            Assert.IsFalse(seabird.Airborne);
        }

        [TestMethod]
        public void Seabird_IncreaseRevs50_Speed50AirborneTrue()
        {
            seabird.IncreaseRevs();
            seabird.IncreaseRevs();
            seabird.IncreaseRevs();
            seabird.IncreaseRevs();

            Assert.AreEqual(seabird.IncreaseRevs(),
                "Seacraft engine increases revs to 50 knots\n");

            Assert.AreEqual(seabird.Speed, 50);
            Assert.IsTrue(seabird.Airborne);
        }

        [TestMethod]
        public void Seabird_TakeOff51Meters_AirborneTrue()
        {
            string output = seabird.TakeOff(51);

            Assert.AreEqual(output,
                "Seacraft engine increases revs to 10 knots\n" +
                "Seacraft engine increases revs to 20 knots\n" +
                "Seacraft engine increases revs to 30 knots\n" +
                "Seacraft engine increases revs to 40 knots\n" +
                "Seacraft engine increases revs to 50 knots\n");

            Assert.IsTrue(seabird.Airborne);
        }

        [TestMethod]
        public void Seabird_TakeOff50Meters_ReturnsException()
        {
            MyAssert.AssertThrows<TooLowException>(() => seabird.TakeOff(50),
                "The seabird cannot fly under 51 meters.");
        }

        [TestMethod]
        public void Seabird_TakeOff10001Meters_ReturnsException()
        {
            MyAssert.AssertThrows<TooHighException>(() => seabird.TakeOff(10001),
                "The seabird cannot fly over 10000 meters.");
        }

    }
}
