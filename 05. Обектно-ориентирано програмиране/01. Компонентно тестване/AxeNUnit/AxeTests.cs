using NUnit.Framework;

namespace AxeNUnit
{
    [TestFixture]
    public class AxeTests
    {
        private const int AxeAttack = 2;
        private const int AxeDurability = 2;
        private const int DummyHealth = 20;
        private const int DummyXP = 20;

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void TestInit()
        {
            this.axe = new Axe(AxeAttack, AxeDurability);
            this.dummy = new Dummy(DummyHealth, DummyXP);
        }

        [Test]
        public void AxeLosesDurabilyAfterAttack()
        {
            axe.Attack(dummy);
            Assert.AreEqual(1, axe.DurabilityPoints, "Axe Durability doesn't change after attack");
        }

        [Test]
        public void BrokenAxeCantAttack()
        {
            axe.Attack(dummy);
            axe.Attack(dummy);
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
        }
    }
}