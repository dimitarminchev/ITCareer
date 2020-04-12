using System;
using DivisionExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DivisionExample.Test
{
    [TestClass]
    public class TestDivision
    {
        [TestMethod]
        public void Dividing4By2Gives2()
        {
            // Arrange
            Divider div = new Divider();

            // Act
            int result = div.Divide(4, 2);

            // Assert
            Assert.AreEqual(2, result, "Dividing 4 by 2 does not result in 2.");
        }

        [TestMethod]
        public void TestDivideZero()
        {
            // Arrange
            Divider div = new Divider();

            // Act
            int result = div.Divide(4, 0);

            // Assert
            Assert.AreEqual(0, result, "Dividing by zero fails");
        }
    }
}
