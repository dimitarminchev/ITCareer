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
    }
}
