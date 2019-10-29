using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class DummyTests
    {        
        [TestMethod]
        // Чучелото губи здраве, ако е атакувано
        public void DummyLosesHealthUnderAttack()
        {
            // Arrange 
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.AreEqual(0, dummy.Health, "Dummy Loses Health Under Attack.");
        }

        [TestMethod]
        // Мъртво чучело хвърля изключение, ако е атакувано
        public void DeadDummyThrowsExceptionUnderAttack()
        {
            // Arrange 
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            // Act
            axe.Attack(dummy);

            // Assert
            var exception = Assert.ThrowsException<InvalidOperationException>
            (
                () => axe.Attack(dummy) // Exception => Dummy is dead. 
            );
            Assert.AreEqual(exception.Message, "Dummy is dead.");
        }

        [TestMethod]
        // Мъртвото чучело може да даде XP
        public void DeadDummyGivesExperience()
        {
            // Arrange 
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);            

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.AreEqual(10, dummy.GiveExperience());
        }

        [TestMethod]
        // Живото чучело не може да даде XP
        public void LiveDummyDoesNotGiveExperience()
        {
            // Arrange 
            Axe axe = new Axe(1, 1);
            Dummy dummy = new Dummy(100, 1000);

            // Act
            axe.Attack(dummy);

            // Assert
            var exception = Assert.ThrowsException<InvalidOperationException>
            (
                () => dummy.GiveExperience() // Exception => Target is not dead. 
            );
            Assert.AreEqual(exception.Message, "Target is not dead.");
        }

    }
}
