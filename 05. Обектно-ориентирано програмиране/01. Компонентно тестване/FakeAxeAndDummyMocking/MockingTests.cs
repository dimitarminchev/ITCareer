using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FakeAxeAndDummyMocking
{
    [TestClass]
    public class MockingTests
    {
        [TestMethod]
        public void HeroGainsExperienceAfterAttackIfTargetIsDead()
        {
            // Arrange

            // 1. Fake Target
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(p => p.Health).Returns(0);
            fakeTarget.Setup(p => p.GiveExperience()).Returns(20);
            fakeTarget.Setup(p => p.IsDead()).Returns(true);

            // 2. Fake Weapon
            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();

            // 3. Hero
            Hero hero = new Hero("Pesho", fakeWeapon.Object);

            // Act
            hero.Attack(fakeTarget.Object);

            // Assert
            Assert.AreEqual(20, hero.Experience);
        }
    }

}