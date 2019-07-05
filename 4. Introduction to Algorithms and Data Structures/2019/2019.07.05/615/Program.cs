using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _615
{
    class Program
    {
        //Автор: Стоян Златев
        // 615 = Combinations without Repetitions
         public static void Permutation(int index, int border = 1)
        {
            if (index == loops.Length)
            {
                Console.WriteLine(string.Join(" ", loops));
                return;
            }
            else
            {
                for (int i = border; i <= n; i++)
                {
                    loops[index] = i;
                    Permutation(index + 1, i+1);
                }
            }
        }
        public static int n = int.Parse(Console.ReadLine());
        public static int k = int.Parse(Console.ReadLine());
        public static int[] loops = new int[k];
        static void Main(string[] args)
        {
            Permutation(0);
        }
    }
}
