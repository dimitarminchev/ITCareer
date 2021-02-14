using NUnit.Framework;
using System;

namespace AxeExample.NUnit
{
    public class DummyTests
    {
        [Test]
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

        [Test]
        public void DeadDummyThrowsExeption()
        {
            // Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(1, 1);

            // Act
            axe.Attack(dummy);

            // Assert
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyGivesExperiense()
        {
            // Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(1, 50);

            // Act
            axe.Attack(dummy);
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));

            // Assert
            Assert.AreEqual(50, dummy.GiveExperience(), "Dead Dummy Does Not Gives Experiense.");
        }

        [Test]
        public void LiveDummyDoesNotGivesExperiense()
        {
            // Arrange
            Axe axe = new Axe(1, 100);
            Dummy dummy = new Dummy(10, 50);

            // Act
            axe.Attack(dummy);

            // Assert
            var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.That(ex.Message, Is.EqualTo("Target is not dead."));
        }
    }
}