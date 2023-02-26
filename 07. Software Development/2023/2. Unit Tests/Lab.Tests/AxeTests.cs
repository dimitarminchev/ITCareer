using NUnit.Framework;

namespace Lab.Tests
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
            Assert.AreEqual(9, axe.DurabilityPoints, "Axe durability does not change after attack.");
        }

        [Test]
        public void BrokenAxeCantAttack()
        {
            // Arrange
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(10, 10);

            // Act
            axe.Attack(dummy);
            axe.Attack(dummy);

            // Assert
            var e = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual(e.Message, "Axe is broken.");
        }

        [Test]
        public void CorrectAttackPoints()
        {
            // Arrange
            Axe axe = new Axe(1,1);

            // Act
            var points = axe.AttackPoints;

            // Assert
            Assert.AreEqual(1, points, "Incorrect attack points.");
        }
    }
}