using NUnit.Framework;
using System;

namespace AxeExample.NunitTests
{
    public class AxeTests
    {
        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            axe.Attack(dummy);

            Assert.AreEqual(9, axe.DurabilityPoints, "Axe durability " +
                "doesnt change after attack.");
        }

        [Test]
        public void BrokenAxeCannotAttack()
        {
            Axe axe = new Axe(1, 2);
            Dummy dummy = new Dummy(10, 1);
            axe.Attack(dummy);
            axe.Attack(dummy);
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}