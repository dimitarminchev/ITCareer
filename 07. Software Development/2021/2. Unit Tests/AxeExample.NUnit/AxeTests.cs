using NUnit.Framework;
using System;

namespace AxeExample.NUnit
{
    public class AxeTests
    {

        [Test]
        public void AxeLosesDurablityAfterAttack()
        {
            // Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.AreEqual(9, axe.DurabilityPoints, "Axe Durability Does Not Change After Attack.");
        }

        [Test]
        public void BrokenAxeCantAttack()
        {
            // Arrange
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(20, 20);

            // Act
            axe.Attack(dummy);
            axe.Attack(dummy);

            // Assert
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
        }
    }
}