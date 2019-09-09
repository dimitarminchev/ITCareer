using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _33_11;
namespace _33_11_Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CreateATuple()
        {
            //Arrange
            _33_11.Tuple<string, int> nameBeer = new _33_11.Tuple<string, int>("Pesho", 15);

            //Act&Assert
            Assert.IsTrue(nameBeer.ToString() == "Pesho -> 15");
        }
    }
}
