using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringsStack;

namespace StringsStackTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StackOfStringExists()
        {
            // Arrange
            Type sut = typeof(StackOfStrings);
            // Act & Assert
            Assert.IsNotNull(sut);
        }

        [TestMethod]
        public void StackOfStringFields()
        {
            // Arrange
            Type sut = typeof(StackOfStrings);
            // Act & Assert
            var fields = sut.GetFields();
            foreach (var fieldInfo in fields)
            {
                Assert.IsTrue(fieldInfo.IsPrivate);
            }
        }

        [TestMethod]
        public void StackOfStringsPop()
        {
            // Arrange
            Type sut = typeof(StackOfStrings);
            // Act 
            var push = sut.GetMethod("Pop");
            // Assert
            Assert.IsNotNull(push);
            Assert.IsTrue(push.ReturnType == typeof(string));
            Assert.IsTrue(push.GetParameters().Length == 0);
        }

        [TestMethod]
        public void StackOfStringsPeek()
        {
            // Arrange
            Type sut = typeof(StackOfStrings);
            // Act 
            var push = sut.GetMethod("Peek");
            // Assert
            Assert.IsNotNull(push);
            Assert.IsTrue(push.ReturnType == typeof(string));
            Assert.IsTrue(push.GetParameters().Length == 0);
        }

        [TestMethod]
        public void StackOfStringsIsEmpty()
        {
            // Arrange
            Type sut = typeof(StackOfStrings);
            // Act
            var push = sut.GetMethod("IsEmpty");
            // Assert
            Assert.IsNotNull(push);
            Assert.IsTrue(push.ReturnType == typeof(bool));
            Assert.IsTrue(push.GetParameters().Length == 0);
        }

        [TestMethod]
        public void StackOfStringsPush()
        {
            // Arrange
            Type sut = typeof(StackOfStrings);
            // Act
            var push = sut.GetMethod("Push");
            // Assert
            Assert.IsNotNull(push);
            Assert.IsTrue(push.ReturnType == typeof(void));
            Assert.IsTrue(push.GetParameters().Length == 1);
        }
    }
}
