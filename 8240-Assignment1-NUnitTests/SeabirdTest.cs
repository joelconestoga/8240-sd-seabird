using System;
using _8240_Assignment1;
using NUnit.Framework;

namespace _8240_Assignment1_NUnitTests
{
    [TestFixture]
    public class SeabirdTest
    {
        Seabird seabird;

        /// <summary>
        /// Instantiate the subject under test
        /// </summary>
        [SetUp]
        public void Setup()
        {
            seabird = new Seabird();
        }

        /// <summary>
        /// Tests object initialization
        /// </summary>
        [Test]
        public void Seabird_DefaultConstructor_SpeedZeroHeightZeroAirborneFalse()
        {
            Assert.AreEqual(seabird.Speed, 0);
            Assert.AreEqual(seabird.Height, 0);
            Assert.IsFalse(seabird.Airborne);
        }

        /// <summary>
        /// Tests the maximum of speed increases before taking off
        /// </summary>
        [Test]
        public void Seabird_IncreaseRevs40_Speed40HeightZeroAirborneFalse()
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
            Assert.AreEqual(seabird.Height, 0);
            Assert.IsFalse(seabird.Airborne);
        }

        /// <summary>
        /// Tests the minimum of incresases for taking off
        /// </summary>
        [Test]
        public void Seabird_IncreaseRevs50_Speed50Height100AirborneTrue()
        {
            seabird.IncreaseRevs();
            seabird.IncreaseRevs();
            seabird.IncreaseRevs();
            seabird.IncreaseRevs();

            Assert.AreEqual(seabird.IncreaseRevs(),
                "Seacraft engine increases revs to 50 knots\n");

            Assert.AreEqual(seabird.Speed, 50);
            Assert.AreEqual(seabird.Height, 100);
            Assert.IsTrue(seabird.Airborne);
        }

        /// <summary>
        /// Tests taking off with a height:
        /// - Larger than the minimum
        /// - Smaller than the initial seabird height
        /// </summary>
        [Test]
        public void Seabird_TakeOff51Meters_Speed50Height100AirborneTrue()
        {
            string output = seabird.TakeOff(51);

            Assert.AreEqual(output,
                "Seacraft engine increases revs to 10 knots\n" +
                "Seacraft engine increases revs to 20 knots\n" +
                "Seacraft engine increases revs to 30 knots\n" +
                "Seacraft engine increases revs to 40 knots\n" +
                "Seacraft engine increases revs to 50 knots\n");

            Assert.AreEqual(seabird.Speed, 50);
            Assert.AreEqual(seabird.Height, 100);
            Assert.IsTrue(seabird.Airborne);
        }

        /// <summary>
        /// Tests taking off with a height larger than the initial seabird height
        /// </summary>
        [Test]
        public void Seabird_TakeOff110Meters_Speed60Height200AirborneTrue()
        {
            string output = seabird.TakeOff(110);

            Assert.AreEqual(output,
                "Seacraft engine increases revs to 10 knots\n" +
                "Seacraft engine increases revs to 20 knots\n" +
                "Seacraft engine increases revs to 30 knots\n" +
                "Seacraft engine increases revs to 40 knots\n" +
                "Seacraft engine increases revs to 50 knots\n" +
                "Seacraft engine increases revs to 60 knots\n");

            Assert.AreEqual(seabird.Speed, 60);
            Assert.AreEqual(seabird.Height, 200);
            Assert.IsTrue(seabird.Airborne);
        }

        /// <summary>
        /// Tests taking off with a height smaller than the minimum of 51 meters
        /// </summary>
        [Test]
        public void Seabird_TakeOff50Meters_ReturnsException()
        {
            MyAssert.AssertThrows<TooLowException>(() => seabird.TakeOff(50),
                "The seabird cannot fly under 51 meters.");
        }

        /// <summary>
        /// Tests taking off with a height larger than the maximum of 400 meters
        /// </summary>
        [Test]
        public void Seabird_TakeOff401Meters_ReturnsException()
        {
            MyAssert.AssertThrows<TooHighException>(() => seabird.TakeOff(401),
                "The seabird cannot fly over 400 meters.");
        }

    }
}
