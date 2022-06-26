using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _311
{
    class Program
    {
        // 3.1.1. Принадлежи ли дадено число на масив
        // O(n) + O(1) + O(n) ~ O(2*N + 1) = O(N)
        static void Main(string[] args)
        {
            // T(3*n + 3) = O(n)
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            // T(4) = O(1)
            int number = int.Parse(Console.ReadLine());

            // T(n + 1) = O(n)
            if (list.Contains(number)) Console.WriteLine($"{number} Exists in the List", number);
            else Console.WriteLine($"{number} Not exists in the ", number);
        }
    }
}
