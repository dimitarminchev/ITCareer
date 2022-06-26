using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _315
{
    class Program
    {
        // 3.1.5. Сбор и Средно аритметично
        // O(n) + O(n) + O(1) ~ O(n )
        static void Main(string[] args)
        {
            // T(3*n + 3) = O(n)
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            // T(2 + 2 + 3*n + 3) ~ O(n)
            int sum = 0; // 2
            float avr = 0; // 2
            foreach (var item in list) // 3*n
            {
                sum = sum + item;     
            }
            avr = sum / list.Count; // 3

            // O(1)
            Console.WriteLine("Sum={0}; Average={1:f2}", sum, avr);

        }
    }
}
