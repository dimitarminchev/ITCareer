using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _721
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            numbers = numbers.Where(n => n % 2 == 0).OrderBy(n => n).ToArray();
            string result = string.Join(", ", numbers);
            Console.WriteLine(result);
        }
    }
}
