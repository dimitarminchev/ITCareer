using Axes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyTests
{
    [TestFixture]
    public class TestClass
    {
        [Test] // Тест дали чучелото губи здраве, ако е атакувано
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

        [Test] // Тест дали мъртво чучело хвърля изключение, ако е атакувано
        public void IsDeadDummyThrowsExceptionUnderAttack()
        {
            // Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(1, 1);

            // Act
            axe.Attack(dummy);

            // Assert
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
        }

        [Test] // Тест дали Мъртвото чучело може да даде XP
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
            Assert.Positive(xp);
        }

        [Test] // Тест дали Живото чучело не може да даде XP
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
            Assert.Zero(xp);
        }

    }
}
