using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem62
{
    class Program
    {
        // Problem 6.2.4. Генериране на 0/1 вектори 
        private static void Gen01(int[] vector, int index)
        {
            if (index > vector.Length - 1)
            {
                Console.WriteLine(string.Join("", vector));
                return;
            }
            for (int i = 0; i <= 1; i++)
            {
                vector[index] = i;
                Gen01(vector, index + 1);
            }
        }

        // Problem 6.2.5. Генериране на комбинации
        private static void GenComb(int[] set, int[] vector, int index, int border)
        {
            if(index == vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
                return;
            }
            for (int i = border; i < set.Length; i++)
            {
                vector[index] = set[i];
                GenComb(set, vector, index + 1, i + 1);
            }
        }

        // Solution
        static void Main(string[] args)
        {
            Console.WriteLine("4. Генериране на 0/1 вектори");
            Console.WriteLine("5. Генериране на комбинации");
            Console.Write("Моля изберете решение [4 или 5]: ");
            var selection = int.Parse(Console.ReadLine());

            // Problem 6.2.4. Генериране на 0/1 вектори
            if (selection == 4)
            {
                int n = int.Parse(Console.ReadLine());
                int[] vector = new int[n];
                Gen01(vector, 0);
            }

            // Problem 6.2.5. Генериране на комбинации
            if (selection == 5)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int n = int.Parse(Console.ReadLine());
                int[] vector = new int[n];
                int[] set = new int[numbers.Count()];
                for (int i = 0; i < numbers.Count(); i++) set[i] = i + 1;
                GenComb(set, vector, 0, 0);
            }
                
        }
    }
}
