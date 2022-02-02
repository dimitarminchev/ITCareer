using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DivisionExample.Tests
{
    [TestClass]
    public class TestDevision
    {
        [TestMethod]
        public void Dividing4By2Gives2()
        {
            // Arrange
            Divider div = new Divider();

            // Act
            var result = div.Divide(4, 2);

            // Assert
            Assert.AreEqual(2, result, "Dividing 4 by 2 does not result in 2.");
        }

        [TestMethod]
        public void DividingByZero()
        {
            // Arrange
            Divider div = new Divider();

            // Act
            var result = div.Divide(1, 0);

            // Assert
            Assert.AreEqual(0, result, "Deviding on zero must return zero.");
        }

    }
}