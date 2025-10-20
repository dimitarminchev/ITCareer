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
            using (StreamReader inputReader = new StreamReader(input))
            using (StreamReader outputReader = new StreamReader(output))
            using (StringWriter outputWriter = new StringWriter())
            {
                Console.SetIn(inputReader);
                Console.SetOut(outputWriter);

                Program.Main(args);

                return outputReader.ReadToEnd() == outputWriter.ToString();
            }
        }

        [TestMethod]
        public void Test1()
        {
            Assert.IsTrue(Check("Test1.in", "Test1.out"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.IsTrue(Check("Test2.in", "Test2.out"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.IsTrue(Check("Test3.in", "Test3.out"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.IsTrue(Check("Test4.in", "Test4.out"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.IsTrue(Check("Test5.in", "Test5.out"));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.IsTrue(Check("Test6.in", "Test6.out"));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.IsTrue(Check("Test7.in", "Test7.out"));
        }
    }
}
