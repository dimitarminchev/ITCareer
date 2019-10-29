using System;
using _32_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _32_1_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateStringArrayTest()
        {
            // Arrange
            string[] strings = ArrayCreator.Create(5, "Pesho");
            // Act & Assert
            Assert.IsTrue(strings[0] == "Pesho");
        }

        [TestMethod]
        public void CreateIntArrayTest()
        {
            // Arrange
            int[] num = ArrayCreator.Create(5, 33);
            // Act & Assert
            Assert.IsTrue(num[0] == 33);
        }
    }
}
