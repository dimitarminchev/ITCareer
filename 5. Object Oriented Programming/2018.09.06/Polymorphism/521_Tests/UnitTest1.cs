using System;
using System.Linq;
using _521;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _521_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MathOperationsExist()
        {
            // Arrange
            Type sut = typeof(MathOperations);
            // Act & Assert
            Assert.IsNotNull(sut);
        }

        [TestMethod]
        public void MathOperationsAddMethodCount()
        {
            // Arrange
            Type sut = typeof(MathOperations);
            // Act
            var methods = sut.GetMethods().Where(n => n.Name == "Add").ToList();
            // Assert
            Assert.IsTrue(methods.Count > 1);
        }

        [TestMethod]
        public void MathOperationsAddInt()
        {
            // Arrange
            Type sut = typeof(MathOperations);
            // Act
            var methods = sut.GetMethods().Where(n => n.Name == "Add").ToList();
            // Assert
            Assert.IsTrue(methods.Any(n => n.GetParameters().All(s => s.ParameterType == typeof(int))));
        }

        [TestMethod]
        public void MathOperationsAddDouble()
        {
            // Arrange
            Type sut = typeof(MathOperations);
            // Act
            var methods = sut.GetMethods().Where(n => n.Name == "Add").ToList();
            // Assert
            Assert.IsTrue(methods.Any(n => n.GetParameters().All(s => s.ParameterType == typeof(double))));
        }

        [TestMethod]
        public void MathOperationsAddDecimal()
        {
            // Arrange
            Type sut = typeof(MathOperations);
            // Act
            var methods = sut.GetMethods().Where(n => n.Name == "Add").ToList();
            // Assert
            Assert.IsTrue(methods.Any(n => n.GetParameters().All(s => s.ParameterType == typeof(decimal))));
        }

        [TestMethod]
        public void MathOperationsAddReturnTypes()
        {
            // Arrange
            Type sut = typeof(MathOperations);
            // Act
            var methods = sut.GetMethods().Where(n => n.Name == "Add").ToList();
            // Assert
            Assert.IsTrue(methods.Any(m => m.ReturnType == typeof(int)));
            Assert.IsTrue(methods.Any(m => m.ReturnType == typeof(double)));
            Assert.IsTrue(methods.Any(m => m.ReturnType == typeof(decimal)));
        }
    }
}
