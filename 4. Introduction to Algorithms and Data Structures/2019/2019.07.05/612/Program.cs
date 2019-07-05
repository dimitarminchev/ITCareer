using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _612
{
    class Program
    {
        //Автор: Стоян Златев
        // 612 = Iterations Variables
         public static void Permutation(int index)
        {
            if (index == loops.Length)
            {
                foreach (var item in loops)
                    Console.Write($"{item} ");
                Console.WriteLine();
                return;
            }
            else
            {
                for (int i = 1; i <=loops.Length; i++)
                {
                    loops[index] = i;
                    Permutation(index + 1);
                }
            }
        }
        public static int n = int.Parse(Console.ReadLine());
        static int[] loops = new int[n];
        static void Main(string[] args)
        {
            Permutation(0);
        }
        
        
        /* Вариант 2
            Автор: Цветилин Цветилов
        static void Rec(int[] numbers, int n, int i, int iter = 0)
        {
            if (iter >= Math.Pow(n, n)) return;
            else
            {
                if (i + 1 == n)
                {
                    iter++;
                    Console.WriteLine(string.Join(" ", numbers));
                }
                if (numbers[i] < n)
                {
                    numbers[i]++;
                    if (i < n - 1) i = n - 1;
                }
                else
                {
                    numbers[i] = 1;
                    i--;
                }
                Rec(numbers, n, i, iter);
            }


        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int p = 0; p < n; p++) nums[p] = 1;
            Rec(nums, n, n - 1);
        }
        */
    }
}
