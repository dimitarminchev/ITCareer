using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AxeExample.Tests
{
    [TestClass]
    public class DummyTests
    {
        [TestMethod]
        public void DummyAxeLosesHealthAfterAttack()
        {
            // Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.AreEqual(0, dummy.Health, "Dummy Health Does Not Change After Attack.");
        }

        [TestMethod]
        public void DeadDummyThrowsExeption()
        {
            // Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(1, 1);

            // Act
            axe.Attack(dummy);

            // Assert
            var ex = Assert.ThrowsException<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual(ex.Message, "Dummy is dead.");
        }

        [TestMethod]
        public void DeadDummyGivesExperiense()
        {
            // Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(1, 50);

            // Act
            axe.Attack(dummy);

            // Assert
            var ex = Assert.ThrowsException<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual(50, dummy.GiveExperience(), "Dead Dummy Does Not Gives Experiense.");
        }

        [TestMethod]
        public void LiveDummyDoesNotGivesExperiense()
        {
            // Arrange
            Axe axe = new Axe(1, 100);
            Dummy dummy = new Dummy(10, 50);

            // Act
            axe.Attack(dummy);

            // Assert
            var ex = Assert.ThrowsException<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.AreEqual(ex.Message, "Target is not dead.");
        }
    }
}