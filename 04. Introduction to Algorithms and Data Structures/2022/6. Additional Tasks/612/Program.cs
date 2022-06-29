using System;

namespace _612
{
    public class Program
    {
        private static int n = int.Parse(Console.ReadLine());

        private static int[] loops = new int[n];


        private static void Permutation(int index)
        {
            // The End
            if (index == loops.Length)
            {
                // Print
                foreach (var item in loops)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
                return; // Exit from Permutation
            }
            // Process permutations
            else 
            {
                for (int i = 1; i <= loops.Length; i++)
                {
                    loops[index] = i;
                    Permutation(index + 1);
                }
            }
        }

        public static void Main(string[] args)
        {
            Permutation(0);
        }
    }
}