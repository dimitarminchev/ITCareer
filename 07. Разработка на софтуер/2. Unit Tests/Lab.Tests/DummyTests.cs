using NUnit.Framework;

namespace Lab.Tests
{
    public class DummyTests
    {
        [Test]
        public void DeadDummyGivesExperiense()
        {
            // Arrange
            Dummy dummy = new Dummy(1, 1);

            // Act
            dummy.TakeAttack(10);

            // Assert
            Assert.AreEqual(1, dummy.GiveExperience(), "Dummy Not Give Experience After Attack");
           
        }

        [Test]
        public void DeadDummyThrowsException()
        {
            // Arrange
            Dummy dummy = new Dummy(1, 1);

            // Act
            dummy.TakeAttack(10);

            // Assert
            var e = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));
            Assert.AreEqual(e.Message, "Dummy is dead.");
        }

        [Test]
        public void DummyLosesHealthAfterAttack()
        {
            // Arrange
            Axe axe = new Axe(1, 1);
            Dummy dummy = new Dummy(10, 10);

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.AreEqual(9, dummy.Health, "Dummy Not Loses Health After Attack");
        }

        [Test]
        public void LiveDummyDoesNotGivesExperiense()
        {
            // Arrange
            Axe axe = new Axe(1, 100);
            Dummy dummy = new Dummy(10, 50);

            // Act
            axe.Attack(dummy);

            // Assert
            var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.AreEqual(ex.Message, "Target is not dead.");
        }

    }
}