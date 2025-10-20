using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Task1;

namespace Task1Tests
{
    [TestClass]
    public sealed class Task1Tests
    {
        private string[] args = null;

        private bool Check(string input, string output)
        {
            using (var inputReader = new StringReader(input))
            using (var outputWriter = new StringWriter())
            {
                Console.SetIn(inputReader);
                Console.SetOut(outputWriter);
                Program.Main(args);
                return outputWriter.ToString() == output;
            }
        }

        [TestMethod]
        public void Test1()
        {
            Assert.IsTrue(Check("az\n", "25\r\n"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.IsTrue(Check("aa\n", "No FuFu\r\n"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.IsTrue(Check("ab\n", "1\r\n"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.IsTrue(Check("am\n", "12\r\n"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.IsTrue(Check("pa\n", "376\r\n"));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.IsTrue(Check("ha\n", "176\r\n"));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.IsTrue(Check("mm\n", "No FuFu\r\n"));
        }
    }
}
