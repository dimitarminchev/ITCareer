using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayStatistics
{
    class Program
    {
        public static void Main()
        {
            // Входни данни
            var array = Console.ReadLine()
                      .Split(' ')
                      .Select(int.Parse)
                      .ToArray();

            // Сметки
            int min = array[0], max = array[0], sum = 0;
            double average = 0.0;
            foreach (var element in array)
            {
                if (element < min) min = element;
                if (element > max) max = element;
                sum += element;                
            }
            average = 1.0*sum / array.Length;

            // Изходни данни
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
            // Console.WriteLine(string.Join(", ",a));
        }

    }
}
