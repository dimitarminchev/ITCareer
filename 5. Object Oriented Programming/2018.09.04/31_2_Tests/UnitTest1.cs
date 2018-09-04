using System;
using _31_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _31_2_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTheBox()
        {
            // Arrange
            Box<int> box = new Box<int>();

            // Act
            box.Add(123);

            // Assert
            Assert.IsTrue("System.Int32: 123" == box.ToString());
        }
    }
}
