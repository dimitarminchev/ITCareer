using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayReverse
{
    class Program
    {
        // 5. Обръщане на елементите на масив
        static void Main(string[] args)
        {
            // Въвеждаме масива (числото n + n реда цели числа)
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            // Извеждаме елементите от последния до първия
            for (int i = n - 1; i >= 0; i--)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

        }
    }
}
