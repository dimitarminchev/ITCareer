using System;
using ColorFigures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorFiguresTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void CircleGetAreaMethodExists()
        {
            // Arrange
            Type obj = typeof(Circle); // Get type pointer
            // Act
            var method = obj.GetMethod("GetArea");
            // Assert
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void CircleGetAreaMethodParameters()
        {
            // Arrange
            Type obj = typeof(Circle); // Get type pointer
            // Act
            var method = obj.GetMethod("GetArea");
            // Assert
            Assert.IsTrue(method.GetParameters().Length == 0);
        }

        [TestMethod]
        public void CircleGetAreaMethodReturnType()
        {
            // Arrange
            Type obj = typeof(Circle); // Get type pointer
            // Act
            var method = obj.GetMethod("GetArea");
            // Assert
            Assert.IsTrue(method.ReturnType == typeof(double));
        }

        [TestMethod]
        public void CircleGetNameMethodExists()
        {
            // Arrange
            Type obj = typeof(Circle); // Get type pointer
            // Act
            var method = obj.GetMethod("GetName");
            // Assert
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void CircleGetNameMethodParameters()
        {
            // Arrange
            Type obj = typeof(Circle); // Get type pointer
            // Act
            var method = obj.GetMethod("GetName");
            // Assert
            Assert.IsTrue(method.GetParameters().Length == 0);
        }

        [TestMethod]
        public void CircleGetNameMethodReturnType()
        {
            // Arrange
            Type obj = typeof(Triangle); // Get type pointer
            // Act
            var method = obj.GetMethod("GetName");
            // Assert
            Assert.IsTrue(method.ReturnType == typeof(string));
        }
    }
}
