using System;
using App1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsOneOdd()
        {
            // Arrage
            OddEven sample = new OddEven();

            // Act & Assert
            Assert.IsTrue(sample.IsOdd(1));
        }

        [TestMethod]
        public void IsOneEven()
        {
            // Arrage
            OddEven sample = new OddEven();

            // Act & Assert
            Assert.IsTrue(sample.IsEven(1));
        }

        [TestMethod]
        public void IsTwoOdd()
        {
            // Arrage
            OddEven sample = new OddEven();

            // Act & Assert
            Assert.IsTrue(sample.IsOdd(2));
        }

        [TestMethod]
        public void IsTwoEven()
        {
            // Arrage
            OddEven sample = new OddEven();

            // Act & Assert
            Assert.IsTrue(sample.IsEven(2));
        }
    }
}
