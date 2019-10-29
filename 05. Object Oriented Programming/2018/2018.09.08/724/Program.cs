using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _724
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(n => n * 1.2).ToList();
            foreach(var num in nums)
            {
                Console.WriteLine("{0:f2}", num);
            }
        }
    }
}
