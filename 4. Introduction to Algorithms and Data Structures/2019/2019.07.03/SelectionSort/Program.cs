using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Масив
            var numbers = new int[] { 9, -9, 8, -8, 7, -7, 6, -6, 5, -5, 4, -4, 3, -3, 2, -2, 1, -1, 0 };

            // Печат
            Console.WriteLine(string.Join(" ", numbers));

            // Разбъркване
            Sort.Shuffle(numbers);

            // Печат
            Console.WriteLine(string.Join(" ", numbers));

            // Сортирне
            Sort.Selection(numbers);

            // Печат
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
