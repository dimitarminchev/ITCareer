using System;
using _522;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _522_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnimalExists()
        { 
            Type sut = typeof(Animal);
            Assert.IsNotNull(sut);
        }

        [TestMethod]
        public void CatExists()
        {
            Type sut = typeof(Cat);
            Assert.IsNotNull(sut);
        }

        [TestMethod]
        public void DogExists()
        {
            Type sut = typeof(Dog);
            Assert.IsNotNull(sut);
        }

        [TestMethod]
        public void VirtualMethod()
        {
            Type sut = typeof(Animal);

            var method = sut.GetMethod("ExplainMyself");

            Assert.IsTrue(method.IsVirtual);
        }

        [TestMethod]
        public void DogOverride()
        {
            Animal dog = new Dog("Gosho", "Meat");

            StringAssert.Contains("WOOF", dog.ExplainMyself());
        }

        [TestMethod]
        public void CatOverride()
        {
            Animal cat = new Cat("Pesho", "Whiskas");

            StringAssert.Contains("MEEOW", cat.ExplainMyself());
        }
    }
}
