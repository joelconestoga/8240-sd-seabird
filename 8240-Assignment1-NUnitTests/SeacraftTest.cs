using System;
using _8240_Assignment1;
using NUnit.Framework;

namespace _8240_Assignment1_NUnitTests
{
    [TestFixture]
    public class SeacraftTest
    {
        Seacraft seacraft;

        /// <summary>
        /// Instantiate the subject under test
        /// </summary>
        [SetUp]
        public void Setup()
        {
            seacraft = new Seacraft();
        }

        /// <summary>
        /// Tests object initialization
        /// </summary>
        [Test]
        public void Seacraft_DefaultConstructor_SpeedZero()
        {
            Assert.AreEqual(seacraft.Speed, 0);
        }

        /// <summary>
        /// Tests the minimum increase of speed
        /// </summary>
        [Test]
        public void Seacraft_IncreaseRevsFromZero_SpeedIs10()
        {
            string output = seacraft.IncreaseRevs();
            Assert.AreEqual(output, "Seacraft engine increases revs to 10 knots");
        }

        /// <summary>
        /// Tests several increases of speed
        /// </summary>
        [Test]
        public void Seacraft_IncreaseRevs3Times_SpeedIs30()
        {
            seacraft.IncreaseRevs();

            string output = seacraft.IncreaseRevs();
            Assert.AreEqual(output, "Seacraft engine increases revs to 20 knots");

            output = seacraft.IncreaseRevs();
            Assert.AreEqual(output, "Seacraft engine increases revs to 30 knots");
        }
    }
}
