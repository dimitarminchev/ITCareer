using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _4_AxeTests
{
    [TestClass]
    public class AxeTests
    {

        [TestMethod] // Тест за издържливостта на бравата след атака
        public void AxeLosesDurabilityAfterAttack()
        {
            // Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            // Act
            axe.Attack(dummy);

            // Assets
            Assert.AreEqual(1, axe.DurabilityPoints, "Axe Durability does not change after attack.");
        }

        [TestMethod] // Тест дали счупена бравата да атакакува
        public void BrokenAxeCantAttack()
        {
            // Arrange
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(20, 20);

            // Act
            axe.Attack(dummy);
            axe.Attack(dummy);

            // Assets           

            //var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            //Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
        }

    }
}
