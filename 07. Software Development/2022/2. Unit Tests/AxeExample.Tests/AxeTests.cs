using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AxeExample.Tests
{
    [TestClass]
    public class AxeTests
    {
        [TestMethod]
        public void AxeLosesDurabilityAfterAttack()
        {
            // Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            // Act 
            axe.Attack(dummy);

            // Assert
            Assert.AreEqual(9, axe.DurabilityPoints, "Axe Duraility does not change after attack.");
        }

        [TestMethod]
        public void BrokenAxeCantAttack()
        {
            // Arrange
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(10, 10);

            // Act 
            axe.Attack(dummy);
            axe.Attack(dummy);

            // Assert
            var ex = Assert.ThrowsException<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual(ex.Message, "Axe is broken.");
        }
    }
}