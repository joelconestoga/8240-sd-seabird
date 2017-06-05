using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _8240_Assignment1;

namespace _8240_Assignment1_Tests
{
    [TestClass]
    public class SeacraftTests
    {
        Seacraft seacraft;

        [TestInitialize]
        public void Setup()
        {
            seacraft = new Seacraft();
        }

        [TestMethod]
        public void Seacraft_DefaultConstructor_SpeedZero()
        {
            Assert.AreEqual(seacraft.Speed, 0);
        }

        [TestMethod]
        public void Seacraft_IncreaseRevsFromZero_SpeedIs10()
        {
            string output = seacraft.IncreaseRevs();
            Assert.AreEqual(output, "Seacraft engine increases revs to 10 knots");
        }

        [TestMethod]
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
