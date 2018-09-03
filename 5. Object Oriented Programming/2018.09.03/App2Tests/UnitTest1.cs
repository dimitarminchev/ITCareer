using System;
using App2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App2Tests
{
    [TestClass]
    public class UnitTest1
    {
        private const string HeroName = "Pesho";

        [TestMethod]
        public void HeroGainsExperienceAfterAttackIfTargetDies()
        {
            // Arrange
            ITarget fakeTarget = new FakeTarget();
            IWeapon fakeWeapon = new FakeWeapon();
            Hero hero = new Hero(HeroName, fakeWeapon);

            // Act
            var xp = hero.Experience;
            hero.Attack(fakeTarget);

            // Assert
            Assert.IsTrue(hero.Experience > xp);
        }

    }
}
