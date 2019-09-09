using System;
using _8_Mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace _9_MockTests
{
    [TestClass]
    public class MockTests
    {
        [TestMethod]
        public void HeroGainsExperienceAfterAttackIfTargetDies()
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
