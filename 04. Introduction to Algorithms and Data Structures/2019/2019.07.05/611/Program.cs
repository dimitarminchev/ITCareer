using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _611
{
    class Program
    {
        private static void Reverse(int[] array, int pos)
        {
            if (pos >= array.Count()) return;
            Reverse(array.Skip(1).ToArray(), pos++);
            Console.Write("{0} ",array[pos-1]);
        }
        // 611 = Array Reverse
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Reverse(numbers, 0);
        }
    }
}
