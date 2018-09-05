using System;
using ColorFigures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorFiguresTests
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void SquareGetAreaMethodExists()
        {
            // Arrange
            Type obj = typeof(Square); // Get type pointer
            // Act
            var method = obj.GetMethod("GetArea");
            // Assert
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void SquareGetAreaMethodParameters()
        {
            // Arrange
            Type obj = typeof(Square); // Get type pointer
            // Act
            var method = obj.GetMethod("GetArea");
            // Assert
            Assert.IsTrue(method.GetParameters().Length == 0);
        }

        [TestMethod]
        public void SquareGetAreaMethodReturnType()
        {
            // Arrange
            Type obj = typeof(Square); // Get type pointer
            // Act
            var method = obj.GetMethod("GetArea");
            // Assert
            Assert.IsTrue(method.ReturnType == typeof(double));
        }

        [TestMethod]
        public void SquareGetNameMethodExists()
        {
            // Arrange
            Type obj = typeof(Square); // Get type pointer
            // Act
            var method = obj.GetMethod("GetName");
            // Assert
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void SquareGetNameMethodParameters()
        {
            // Arrange
            Type obj = typeof(Square); // Get type pointer
            // Act
            var method = obj.GetMethod("GetName");
            // Assert
            Assert.IsTrue(method.GetParameters().Length == 0);
        }

        [TestMethod]
        public void SquareGetNameMethodReturnType()
        {
            // Arrange
            Type obj = typeof(Square); // Get type pointer
            // Act
            var method = obj.GetMethod("GetName");
            // Assert
            Assert.IsTrue(method.ReturnType == typeof(string));
        }
    }
}
