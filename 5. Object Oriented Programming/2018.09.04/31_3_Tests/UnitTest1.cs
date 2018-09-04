using System;
using _31_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _31_3_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreatingOneElementArray()
        {
            Box<string>[] strings = new Box<string>[1];
            strings[0] = new Box<string>();
            strings[0].Add("hi");

            Assert.IsTrue(strings[0].ToString() == "System.String: hi");
        }
    }
}
