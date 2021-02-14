using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AxeExample.MSTest
{
    [TestClass]
    public class AxeTests
    {
        [TestMethod]
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

        [TestMethod]
        public void BrokenAxeCantAttack()
        {
            // Arrange
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(20, 20);

            // Act
            axe.Attack(dummy);
            axe.Attack(dummy);

            // Assert
            var ex = Assert.ThrowsException<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual(ex.Message, "Axe is broken.");
        }
    }
}
