using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08._Dependencies_Tests
{
    [TestClass]
    public class DependenciesTests
    {
        [TestMethod]
        public void HeroGainsExperienceAfterAttackIfTargetIsDead()
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