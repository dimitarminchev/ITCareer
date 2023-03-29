using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DummyMSTest
{
    [TestClass]
    public class DummyTests
    {
        [TestMethod]
        public void DummyLosesHealthWhenIsAttacked()
        {
            // Arrange
            Axe axe = new Axe(1, 10);
            Dummy dum = new Dummy(10, 10);

            // Act
            var oldHealth = dum.Health;
            axe.Attack(dum);

            // Assert
            Assert.AreNotSame(oldHealth, dum.Health);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Dummy is dead.")]

        public void IsDeadDummyThrowsExceptionUnderAttack()
        {
            // Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(1, 1);

            // Act
            axe.Attack(dummy);
            axe.Attack(dummy); // Expected Exception here!

            // Assert
            Assert.IsTrue(dummy.Health > 0);
        }

        [TestMethod]
        public void IsDeadDummyGiveXP()
        {
            // Arrange           
            Dummy dummy = new Dummy(1, 1);
            Hero hero = new Hero("Коняря");

            // Act
            var xp = hero.Experience;
            hero.Attack(dummy);
            xp = hero.Experience - xp;

            // Assert
            Assert.IsTrue(xp > 0);
        }

        [TestMethod]
        public void IsAliveDummyGiveXP()
        {
            // Arrange           
            Dummy dummy = new Dummy(100, 100);
            Hero hero = new Hero("Коняря");

            // Act
            var xp = hero.Experience;
            hero.Attack(dummy);
            xp = hero.Experience - xp;

            // Assert
            Assert.IsTrue(xp == 0);
        }
    }

}