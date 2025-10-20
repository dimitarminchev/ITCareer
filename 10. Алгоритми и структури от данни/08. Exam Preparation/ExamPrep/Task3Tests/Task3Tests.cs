using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Task3;

namespace Task3Tests
{
    [TestClass]
    public sealed class Task3Tests
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
            Assert.IsTrue(Check("10 20 30\n", "20\r\n"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.IsTrue(Check("1 4 100\n", "99\r\n"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.IsTrue(Check("100 1 91\n", "99\r\n"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.IsTrue(Check("71 85 88\n", "17\r\n"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.IsTrue(Check("23 82 95\n", "72\r\n"));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.IsTrue(Check("6 9 3\n", "6\r\n"));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.IsTrue(Check("1 1 1\n", "0\r\n"));
        }
    }
}
