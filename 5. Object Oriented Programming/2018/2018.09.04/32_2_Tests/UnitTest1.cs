using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using _32_2;
using System.Collections.Generic;
namespace _32_2_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FunctionAddAddsStringBoxesToList()
        {
            List<Box<string>> numbers = new List<Box<string>>();
            numbers.Add(new Box<string>("Pesho"));
            numbers.Add(new Box<string>("Ivan"));

            Assert.IsTrue(numbers.Count == 2);
        }

        [TestMethod]
        public void SwapperSwapsStringBoxesInList()
        {
            List<Box<string>> numbers = new List<Box<string>>();
            numbers.Add(new Box<string>("Pesho"));
            numbers.Add(new Box<string>("Ivan"));


            Swapper.Swap(numbers, 0, 1);
            Assert.IsTrue(numbers[0].Item == "Ivan" && numbers[1].Item == "Pesho");
        }
    }
}
