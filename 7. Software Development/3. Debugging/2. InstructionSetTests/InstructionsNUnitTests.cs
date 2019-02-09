using NUnit.Framework;
using _1.InstructionSet;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void IncrementTest()
        {
            // Arrange
            var instruction = new Instructions();

            // Act
            var result = instruction.Execute("INC 0");

            // Assert
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void AdditionTest()
        {
            // Arrange
            var instruction = new Instructions();

            // Act
            var result = instruction.Execute("ADD 1 2");

            // Assert
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void DecrementTest()
        {
            // Arrange
            var instruction = new Instructions();

            // Act
            var result = instruction.Execute("DEC 2");

            // Assert
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void MultiplyTest()
        {
            // Arrange
            var instruction = new Instructions();

            // Act
            var result = instruction.Execute("MLA 2 3");

            // Assert
            Assert.AreEqual(result, 6);
        }

    }
}