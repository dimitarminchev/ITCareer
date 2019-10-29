using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _625
{
    class Program
    {
        //Автор: Стоян Златев
        // 625 = Combinations
        public static void Combination(int index, int[] arr, int border = 0)
        {
            if (index == loops.Length)
            {
                Console.WriteLine(string.Join(" ", loops));
                return;
            }
            else
            {
                for (int i = border; i < arr.Length; i++)
                {
                    loops[index] = arr[i];
                    Combination(index + 1, arr, i + 1);
                }
            }
        }
        public static int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        public static int n = int.Parse(Console.ReadLine());
        public static int[] loops = new int[n];
        static void Main(string[] args)
        {
            Combination(0, array);
        }
    }
}
