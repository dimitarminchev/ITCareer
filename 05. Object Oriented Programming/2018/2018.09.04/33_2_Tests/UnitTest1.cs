using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _33_2;

namespace _33_2_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TetsAddingThreeElements()
        {
            // Arrange
            CustomList<int> lis = new CustomList<int>();

            // Act
            lis.Add(1);
            lis.Add(2);
            lis.Add(3);

            // Assert
            Assert.IsTrue(lis.Count == 3);
        }
        [TestMethod]
        public void TestSwapingTwoElements()
        {
            // Arrange
            CustomList<int> lis = new CustomList<int>();

            // Act
            lis.Add(1);
            lis.Add(2);
            lis.Swap(0, 1);

            // Assert
            Assert.IsTrue(lis.ToString() == "2 1 ");
        }
    }
}
