using System;
using _531;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _531_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShapeAbstract()
        {
            Type sut = typeof(Shape);

            Assert.IsTrue(sut.IsAbstract);
        }

        [TestMethod]
        public void RectangleExist()
        {
            Type sut = typeof(Rectangle);

            Assert.IsNotNull(sut);
        }

        [TestMethod]
        public void CircleExist()
        {
            Type sut = typeof(Circle);

            Assert.IsNotNull(sut);
        }

        [TestMethod]
        public void CircleBase()
        {
            Type baseClass = typeof(Shape);
            Type derived = typeof(Circle);

            Assert.IsTrue(derived.BaseType == baseClass);
        }

        [TestMethod]
        public void RectangleBase()
        {
            Type baseClass = typeof(Shape);
            Type derived = typeof(Rectangle);

            Assert.IsTrue(derived.BaseType == baseClass);
        }

        [TestMethod]
        public void CircleStats()
        {
            var circle = new Circle(2.2);

            Assert.AreEqual("15.21", $"{circle.CalculateArea():N2}");
            Assert.AreEqual("13.82", $"{circle.CalculatePerimeter():N2}");
        }

        [TestMethod]
        public void RectangleStats()
        {
            var rect = new Rectangle(2, 5);

            Assert.AreEqual("10", $"{rect.CalculateArea()}");
            Assert.AreEqual("14", $"{rect.CalculatePerimeter()}");
        }

        [TestMethod]
        public void DrawMethod()
        {
            var rect = new Rectangle(2, 5);
            Assert.AreEqual("Drawing Rectangle", $"{rect.Draw()}");

            var circle = new Circle(2);
            Assert.AreEqual("Drawing Circle", $"{circle.Draw()}");
        }
    }
}
