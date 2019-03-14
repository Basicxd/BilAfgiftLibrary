using System;
using BilAfgiftLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilAfgiftTest
{
    [TestClass]
    public class BilAfgiftUnitTest
    {
        [TestMethod]
        public void BilAfgiftErMindreEndEllerLigMed200000()
        {
            //Arrange
            var bilafgift = new Afgift();

            //Act
            double afgift = bilafgift.BilAfgift(100000);

            //Assert
            Assert.AreEqual(85000, afgift);
        }

        [TestMethod]
        public void BilAfgiftErStørreEnd200000()
        {
            //Arrange
            var bilafgift = new Afgift();

            //Act
            double afgift = bilafgift.BilAfgift(300000);

            //Assert
            Assert.AreEqual(320000, afgift);
        }

        [TestMethod]
        public void ElBilAfgift()
        {
            //Arrange
            var bilafgift = new Afgift();

            //Act
            double afgift = bilafgift.ElBilAfgift(100000);

            //Assert
            Assert.AreEqual(17000, afgift);
        }
    }
}
