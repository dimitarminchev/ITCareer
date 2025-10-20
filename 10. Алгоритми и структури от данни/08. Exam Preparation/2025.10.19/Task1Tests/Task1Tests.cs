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
    }
}
