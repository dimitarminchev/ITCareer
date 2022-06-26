using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _327
{
    class Program
    {
        // 3.2.7. Средно аритметично и сума на спъсък 
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
