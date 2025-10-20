namespace Task4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        private static List<string> PermutationsList = new List<string>();

        private static int[] elements;
        private static bool[] used;
        private static int[] perm;

        private static void Permutation(int index)
        {
            if (index >= elements.Length)
            {
                int counter = 0;
                for (int i = 1; i < perm.Length; i++)
                {
                    if (perm[i - 1] > perm[i])
                    {
                        counter++;
                    }
                }
                if (counter % 2 == 0 && counter > 0)
                {
                    PermutationsList.Add(string.Join(" ", perm));
                }
            }
            else
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        perm[index] = elements[i];
                        Permutation(index + 1);
                        used[i] = false;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            used = new bool[elements.Length];
            perm = new int[elements.Length];

            Permutation(0);

            PermutationsList.Sort();
            PermutationsList.ForEach(x => Console.WriteLine(x));
        }
    }
}
