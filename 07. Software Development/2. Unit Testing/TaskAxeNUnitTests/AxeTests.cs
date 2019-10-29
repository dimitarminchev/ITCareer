using NUnit.Framework;
using System;

namespace Tests
{
    public class AxeTests
    {
        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            // Arrange 
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.AreEqual(9, axe.DurabilityPoints,
                "Axe durability changes after the attack.");
        }

        [Test]
        public void BrokenAxeCanAttack()
        {
            // Arrange 
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(20, 20);

            // Act
            axe.Attack(dummy);
            axe.Attack(dummy); // Exception => Axe is broken.

            // Assert
            var exception = Assert.Throws<InvalidOperationException>
            (
                () => axe.Attack(dummy)
            );
            Assert.AreEqual(exception.Message, "Axe is broken.");

        }
    }
}