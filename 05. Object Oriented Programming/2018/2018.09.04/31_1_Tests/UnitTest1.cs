using System;
using _31_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _31_1_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdding3Elements()
        {
            // Arrange
            Box<int> box = new Box<int>();

            // Act
            box.Add(1);
            box.Add(2);
            box.Add(3);

            // Assert
            Assert.IsTrue(box.Count == 3);
        }

        [TestMethod]
        public void TestRemoving1Element()
        {
            // Arrange
            Box<int> box = new Box<int>();

            // Act
            box.Add(1);
            var one = box.Remove();

            // Assert
            Assert.IsTrue(one == 1);
        }
    }
}
