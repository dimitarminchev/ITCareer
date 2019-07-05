using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _621
{
    class Program
    {
        // 621 = Recursive Array Sum
        private static int Sum(int[] array, int index) 
        {
            int sum = 0;
            if (index <= 0) return 0;
            return (Sum(array, index - 1) + array[index - 1]);
        }
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();


            Console.WriteLine(Sum(a, a.Length));
        }
    }
}
