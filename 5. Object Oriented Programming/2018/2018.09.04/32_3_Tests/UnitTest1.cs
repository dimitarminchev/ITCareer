using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _32_3;
namespace _32_3_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FunctionAddAddsNumbersToList()
        {
            List<Box<int>> numbers = new List<Box<int>>();
            numbers.Add(new Box<int>(2));
            numbers.Add(new Box<int>(5));

            Assert.IsTrue(numbers.Count == 2);
        }

        [TestMethod]
        public void SwapperSwapsBoxesInList()
        {
            List<Box<int>> numbers = new List<Box<int>>();
            numbers.Add(new Box<int>(2));
            numbers.Add(new Box<int>(5));


            Swapper.Swap(numbers, 0 , 1);
            Assert.IsTrue(numbers[0].Item == 5 && numbers[1].Item == 2);
        }
    }
}
