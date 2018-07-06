using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem61
{
    class Program
    {
        // 1. Обръщане последователността на масив
        private static void ReverseArray(int[] array, int pos)
        {
            if (pos >= array.Count()) return;
            ReverseArray(array.Skip(1).ToArray(), pos++);
            Console.Write("{0} ",array[pos -1]);
        }

        // 2. Вложени цикли и рекурсия
        private static void NestedLoops(int n)
        {
            Console.WriteLine("NO SOLUTION");
        }

        // Problem 6.1
        static void Main(string[] args)
        {
            // Menu
            Console.WriteLine("1. Обръщане последователността на масив");
            Console.WriteLine("2. Вложени цикли и рекурсия");
            Console.WriteLine("3. Комбинация с повторения");
            Console.WriteLine("4. Ханойски кули");
            Console.WriteLine("5. Комбинации без повторения");
            Console.WriteLine("6. Свързани масиви в матрица");
            Console.Write("Моля изберете решение [от 1 до 6]: ");
            var selection = int.Parse(Console.ReadLine());

            // 1. Обръщане последователността на масив
            if (selection == 1)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                ReverseArray(numbers, 0);
            }

            // 2. Вложени цикли и рекурсия
            if (selection == 2)
            {
                int n = int.Parse(Console.ReadLine());
                NestedLoops(n);
            }

            // 3. Комбинация с повторения
            if (selection == 3)
            {
                // TODO
            }

            // 4. Ханойски кули
            if (selection == 4)
            {
                // TODO
            }

            // 5. Комбинации без повторения
            if (selection == 5)
            {
                // TODO
            }

            // 6. Свързани масиви в матрица
            if (selection == 6)
            {
                // TODO
            }
        }
    }
}
