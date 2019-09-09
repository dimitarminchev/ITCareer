using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _33_12;

namespace _33_12_Tests
{
    [TestClass]
    public class ThreeupleTests
    {
        [TestMethod]
        public void CreateAThreeuple()
        {
            //Arrange
            _33_12.Threeuple<string, double, string> test = new Threeuple<string, double, string>
                ("Pesho", 8.36, "Purva investicionna banka");

            //Act & Assert
            Assert.IsTrue(test.ToString() == "Pesho -> 8.36 -> Purva investicionna banka");
        }
    }
}
