using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3207
{
    class Program
    {
        // Problem 7. Средно аритметично и сума на спъсък 
        static void Main(string[] args)
        {
            // Input
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            // Sum and Avrerage
            Console.WriteLine("Sum = {0}", list.Sum());
            Console.WriteLine("Average = {0}", list.Average());

        }
    }
}
