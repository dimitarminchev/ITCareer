using Axes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxeTests
{
    [TestFixture]
    public class AxeTests
    {
        [Test] // Тест за издържливостта на бравата след атака
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

        [Test] // Тест дали счупена бравата да атакакува
        public void BrokenAxeCantAttack()
        {
            // Arrange
            Axe axe = new Axe(2,2);
            Dummy dummy = new Dummy(20,20);

            // Act
            axe.Attack(dummy);
            axe.Attack(dummy);

            // Assets
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
        }
    }
}
