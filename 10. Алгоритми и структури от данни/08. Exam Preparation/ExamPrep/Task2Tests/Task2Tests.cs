using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Task2;

namespace Task2Tests
{
    [TestClass]
    public sealed class Task2Tests
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
            Assert.IsTrue(Check("3 3\n0 0 0\n0 1 0\n0 0 0\n", "1\r\n"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.IsTrue(Check("5 5\n0 0 0 0 1\n0 0 0 0 0\n0 1 0 0 1\n0 0 0 1 0\n1 0 0 0 0\n", "4\r\n"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.IsTrue(Check("5 10\n1 1 0 0 0 0 0 0 0 0\n0 1 1 0 0 0 0 1 0 0\n0 0 0 0 0 0 0 0 1 0\n0 0 1 0 0 1 0 0 0 0\n0 0 0 0 1 0 0 0 0 0\n", "4\r\n"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.IsTrue(Check("2 2\n0 0\n0 0\n", "0\r\n"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.IsTrue(Check("3 3\n1 1 1\n1 1 1\n1 1 1\n", "1\r\n"));
        }
    }
}
