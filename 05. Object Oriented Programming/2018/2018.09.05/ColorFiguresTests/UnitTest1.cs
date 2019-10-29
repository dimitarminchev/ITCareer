using System;
using ColorFigures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorFiguresTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TriangleGetAreaMethodExists()
        {
            // Arrange
            Type obj = typeof(Triangle); // Get type pointer
            // Act
            var method = obj.GetMethod("GetArea");
            // Assert
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void TriangleGetAreaMethodParameters()
        {
            // Arrange
            Type obj = typeof(Triangle); // Get type pointer
            // Act
            var method = obj.GetMethod("GetArea");
            // Assert
            Assert.IsTrue(method.GetParameters().Length == 0);
        }

        [TestMethod]
        public void TriangleGetAreaMethodReturnType()
        {
            // Arrange
            Type obj = typeof(Triangle); // Get type pointer
            // Act
            var method = obj.GetMethod("GetArea");
            // Assert
            Assert.IsTrue(method.ReturnType == typeof(double));
        }

        [TestMethod]
        public void TriangleGetNameMethodExists()
        {
            // Arrange
            Type obj = typeof(Triangle); // Get type pointer
            // Act
            var method = obj.GetMethod("GetName");
            // Assert
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void TriangleGetNameMethodParameters()
        {
            // Arrange
            Type obj = typeof(Triangle); // Get type pointer
            // Act
            var method = obj.GetMethod("GetName");
            // Assert
            Assert.IsTrue(method.GetParameters().Length == 0);
        }

        [TestMethod]
        public void TriangleGetNameMethodReturnType()
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
