using System;
using App2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace App2Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void HeroGainsExperienceAfterAttackIfTargetDies()
        {
            // Arrange
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(p => p.Health).Returns(0);
            fakeTarget.Setup(p => p.GiveExperience()).Returns(20);
            fakeTarget.Setup(p => p.IsDead()).Returns(true);
            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            Hero hero = new Hero("Pesho", fakeWeapon.Object);

            // Akt
            hero.Attack(fakeTarget.Object);

            // Assert
            Assert.AreEqual(20, hero.Experience);
        }

    }
}
