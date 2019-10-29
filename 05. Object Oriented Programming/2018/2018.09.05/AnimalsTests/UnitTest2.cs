using System;
using Animals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalsTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void AnimalEat()
        {
            // Arrange
            Type animal = typeof(Puppy); // Get type pointer
            // Act
            var method = animal.GetMethod("Weep");
            // Assert
            Assert.IsTrue(method.ReturnType == typeof(void));
        }

        [TestMethod]
        public void EatParameters()
        {
            // Arrange
            Type animal = typeof(Puppy); // Get type pointer
            // Act
            var method = animal.GetMethod("Weep");
            // Assert
            Assert.IsTrue(method.GetParameters().Length == 0);
        }

        [TestMethod]
        public void DogTest()
        {
            // Arrange
            Type animal = typeof(Dog); // Get type pointer
            // Act
            var method = animal.GetMethod("Bark");
            // Assert
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void EatReturnType()
        {
            // Arrange
            Type animal = typeof(Puppy); // Get type pointer
            // Act
            var method = animal.GetMethod("Weep");
            // Assert
            Assert.IsTrue(method.ReturnType == typeof(void));
        }

        [TestMethod]
        public void BarkParameters()
        {
            // Arrange
            Type animal = typeof(Dog); // Get type pointer
            // Act
            var method = animal.GetMethod("Bark");
            // Assert
            Assert.IsTrue(method.GetParameters().Length == 0);
        }

        [TestMethod]
        public void BarkReturnType()
        {
            // Arrange
            Type animal = typeof(Dog); // Get type pointer
            // Act
            var method = animal.GetMethod("Bark");
            // Assert
            Assert.IsTrue(method.ReturnType == typeof(void));
        }

        [TestMethod]
        public void Inheritance()
        {
            // Arrage
            Type animal = typeof(Puppy); // Get type pointer
            // Ack & Assert
            Assert.IsTrue(animal.BaseType == typeof(Dog));
        }
    }
}
