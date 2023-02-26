using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Division.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Dividing4by2gives2()
        {
            // Arrange
            Divider div = new Divider();

            // Act
            var result = div.Divide(4, 2);

            // Assert           
            Assert.AreEqual(2, result, "Dividing 4 by 2 doesn't result in 2.");
        }

        [TestMethod]
        public void Dividing1by0gives0()
        {
            // Arrange
            Divider div = new Divider();

            // Act
            var result = div.Divide(1, 0);

            // Assert           
            Assert.AreEqual(0, result, "Dividing 1 by 0 doesn't result in 0.");
        }
    }
}