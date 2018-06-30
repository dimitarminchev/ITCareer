using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            // O(N^3)
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // O(1)
            int n = int.Parse(Console.ReadLine());
            
            // O(N)
            bool exists = numberExists(n, numbers);

            // O(1)
            if(exists) Console.WriteLine($"{n} Exists in the List"); 
            else Console.WriteLine($"“{n} Not exists in the List");
        }

        // O(N)
        private static bool numberExists(int n, int[] numbers)
        {
            for (int i = 0; i < numbers.Count(); i++)
              if (numbers[i] == n)
                    return true;
            return false;
        }
    }
}
