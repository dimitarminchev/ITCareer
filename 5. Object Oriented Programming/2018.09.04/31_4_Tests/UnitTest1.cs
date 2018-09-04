using System;
using _31_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _31_4_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreatingOneElementArray()
        {
            Box<int>[] strings = new Box<int>[1];
            strings[0] = new Box<int>();
            strings[0].Add(12);
            Assert.IsTrue(strings[0].ToString() == "System.Int32: 12");
        }
    }
}
