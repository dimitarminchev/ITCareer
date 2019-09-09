using System;
using _6_Dependencies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _7_DependenciesTests
{
    [TestClass]
    public class DependenciesTest
    {
        [TestMethod]
        public void HeroGainsExperienceAfterAttackIfTargetDies()
        {
            // Arrange
            ITarget fakeTarget = new FakeTarget();
            IWeapon fakeWeapon = new FakeWeapon();
            Hero hero = new Hero("Pesho", fakeWeapon);

            // Act            
            hero.Attack(fakeTarget);

            // Assert
            Assert.IsTrue(hero.Experience > 0);
        }

    }
}
