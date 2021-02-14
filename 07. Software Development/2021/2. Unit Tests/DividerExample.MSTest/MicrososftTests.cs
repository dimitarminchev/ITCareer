using Microsoft.VisualStudio.TestTools.UnitTesting; 

namespace DividerExample.MSTest
{
    [TestClass]
    public class MicrososftTests
    {
        [TestMethod]
        public void Dividing4By2Gives2()
        {
            // Arrange & Act
            var result = Divider.Divide(4, 2);

            // Assert
            Assert.AreEqual(2, result, "Dividing 4 by 2 does not result in 2.");
        }

        [TestMethod]
        public void Dividing1By0GivesZero()
        {
            // Arrange & Act
            var result = Divider.Divide(1, 0);

            // Assert
            Assert.AreEqual(0, result, "Dividing 1 by 0 does not gives ZERO.");
        }

    }
}
