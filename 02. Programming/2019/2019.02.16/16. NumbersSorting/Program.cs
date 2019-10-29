using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.NumbersSorting
{
    class Program
    {
        // 16. Сортиране на числа
        static void Main(string[] args)
        {
            List<double> nums =  Console.ReadLine().Split().Select(double.Parse).ToList();
            nums.Sort();
            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}
