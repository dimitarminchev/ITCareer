using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AxeMSTest
{
    [TestClass]
    public class AxeTests
    {
        private const int AxeAttack = 2;
        private const int AxeDurability = 2;
        private const int DummyHealth = 20;
        private const int DummyXP = 20;

        private Axe axe = new Axe(AxeAttack, AxeDurability);
        private Dummy dummy = new Dummy(DummyHealth, DummyXP);

        [TestMethod]
        public void AxeLosesDurabilyAfterAttack()
        {
            axe.Attack(dummy);
            Assert.AreEqual(1, axe.DurabilityPoints, "Axe Durability doesn't change after attack");
        }

        [TestMethod]
        public void BrokenAxeCantAttack()
        {
            axe.Attack(dummy);
            axe.Attack(dummy);
            var ex = Assert.ThrowsException<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual(ex.Message, "Axe is broken.");
        }
    }
}