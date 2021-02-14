using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumExample.MSTest
{
    [TestClass]
    public class MicrosoftTests
    {
        [TestMethod]
        public void TestSumIfOnePlusTwoEqualsThree()
        {
            // Arrange & Act
            var sum = Sumator.Sum(new int[] { 1, 2 });

            // Assert
            Assert.AreEqual(3, sum, "1+2 != 3");
        }

        [TestMethod]
        public void TestSumIfMinus2isEqualMinus2()
        {
            // Arrange & Act
            var sum = Sumator.Sum(new int[] { -2 });

            // Assert
            Assert.AreEqual(-2, sum, "-2 != -2");
        }

        [TestMethod]
        public void TestSumWithEmptyArrayToGiveZero()
        {
            // Arrange & Act
            var sum = Sumator.Sum(new int[] { });

            // Assert
            Assert.AreEqual(0, sum, "0 != 0");
        }
    }
}
