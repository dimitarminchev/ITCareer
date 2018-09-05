using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomList;

namespace RandomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RandomListExist()
        {
            // Arrange
            Type type = typeof(RandomList.RandomList);
            // Act & Assert
            Assert.IsNotNull(type); // VSTT
            // Assert.NotNull(type); // NUNIT
        }

        [TestMethod]
        public void RandomStringBaseClass()
        {
            // Arrange
            Type list = typeof(RandomList.RandomList);
            // Act & Assert
            Assert.IsTrue(list.BaseType == typeof(ArrayList));
        }

        [TestMethod]
        public void RandomStringExist()
        {
            // Arrange
            Type list = typeof(RandomList.RandomList);
            // Act
            var methods = list.GetMethods();
            // Assert
            Assert.IsTrue(methods.Select(n => n.Name).Contains("RandomString"));
        }
    }
}
