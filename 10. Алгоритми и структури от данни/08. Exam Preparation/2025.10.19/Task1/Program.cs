using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class Program
    {
        private static int[] arr;
        private static bool[] used;
        private static int[] perm;
        private static int counter = 0;

        private static void Permute(int index)
        {
            if (index >= arr.Length)
            {
                counter++;
                Console.WriteLine($"{counter}: {string.Join(" ", perm)}");
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    perm[index] = arr[i];
                    Permute(index + 1);
                    used[i] = false;
                }
            }
        }

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            arr = Enumerable.Range(1, n).ToArray();
            used = new bool[n];
            perm = new int[n];
            Permute(0);
        }
    }
}
