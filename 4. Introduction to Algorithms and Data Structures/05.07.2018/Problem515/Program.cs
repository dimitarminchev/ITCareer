using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem515
{
    class Program
    {
        // Problem 515. Игли
        static void Needles(int c, int n, int[] array, int[] toInsert)
        {
            for (int i = 0; i < n; i++)
            {
                int index = c;
                for (int k = c - 1; k >= 0; k--)
                {
                    if (array[k] == 0 || array[k] >= toInsert[i])
                    {
                        index--;
                    }
                    else
                    {
                        Console.Write(index + " ");
                        break;
                    }
                    if (index == 0) Console.Write(index + " ");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] cnInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] startArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] toInsert = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int c = cnInput[0];
            int n = cnInput[1];
            Needles(c, n, startArray, toInsert);
        }
    }
}
