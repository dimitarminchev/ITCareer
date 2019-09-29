using System;
using System.Collections.Generic;
using System.Linq;

namespace TheMadGardener
{
    class Program
    {
        class Sequence
        {
            public int Length { get; set; }
            public int PrevElement { get; set; }
            public int Sum { get; set; }
        }
        static int[] result;
        static int bestLength = 0;
        static int peek = 0;
        static int bestSum = 0;

        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            int[] plants = new int[input.Length + 1];
            result = new int[plants.Length];
            Sequence[] firstMaxSequence = new Sequence[plants.Length];
            Sequence[] secondMaxSequence = new Sequence[plants.Length];

            for (int i = 0; i < plants.Length; i++)
            {
                firstMaxSequence[i] = new Sequence();
                secondMaxSequence[i] = new Sequence();
            }
            int[] reversedPlants = new int[plants.Length];

            for (int i = 0; i < input.Length; i++)
            {
                plants[i + 1] = input[i];
            }


            Solution(firstMaxSequence, secondMaxSequence, reversedPlants, plants);
            BuildSequence(firstMaxSequence, secondMaxSequence, reversedPlants, plants);
            PrintSolution();
        }

        private static void PrintSolution()
        {
            for (int i = 1; i < bestLength; i++)
            {
                Console.Write($"{result[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"{(bestSum / ((bestLength - 1) * 1.00)):F2}");
            Console.WriteLine(bestLength - 1);
        }

        private static void BuildSequence(Sequence[] firstMaxSequence, Sequence[] secondMaxSequence, int[] reversedPlants, int[] plants)
        {
            int length = 0;
            int index = peek;
            int element = firstMaxSequence[index].Length;
            while (index != 0)
            {
                result[element - length++] = plants[index];
                index = firstMaxSequence[index].PrevElement;
            }

            index = secondMaxSequence[plants.Length - 1 - peek + 1].PrevElement;
            while (index != 0)
            {
                result[++length] = reversedPlants[index];
                index = secondMaxSequence[index].PrevElement;
            }

        }

        private static void Solution(Sequence[] firstMaxSequence, Sequence[] secondMaxSequence, int[] reversedPlants, int[] plants)
        {
            FindIncreasingSequence(firstMaxSequence, plants);
            Reverse(reversedPlants, plants);
            FindIncreasingSequence(secondMaxSequence, reversedPlants);
            int n = plants.Length - 1;

            for (int i = 1; i <= n; i++)
            {
                if (((firstMaxSequence[i].Length + secondMaxSequence[n - i + 1].Length > bestLength)) || ((firstMaxSequence[i].Length + secondMaxSequence[n - i + 1].Length == bestLength) && (firstMaxSequence[i].Sum + secondMaxSequence[n - i + 1].Sum > bestSum)))
                {
                    bestLength = firstMaxSequence[i].Length + secondMaxSequence[n - i + 1].Length;
                    bestSum = firstMaxSequence[i].Sum + secondMaxSequence[n - i + 1].Sum - plants[i];
                    peek = i;
                }
            }
        }

        private static void Reverse(int[] reversedPlants, int[] plants)
        {
            for (int i = 1; i <= plants.Length - 1; i++)
            {
                reversedPlants[i] = plants[(plants.Length - 1) - i + 1];
            }
        }


        private static void FindIncreasingSequence(Sequence[] maxSequence, int[] plants)
        {
            for (int i = 1; i <= plants.Length - 1; i++)
            {
                maxSequence[i].Length = maxSequence[i].Sum = 0;
                for (int j = 0; j < i; j++)
                {
                    if (plants[j] <= plants[i])
                    {
                        if (maxSequence[j].Length + 1 > maxSequence[i].Length || ((maxSequence[j].Length + 1 == maxSequence[i].Length) && (maxSequence[j].Sum + plants[i] > maxSequence[i].Sum)))
                        {
                            maxSequence[i].PrevElement = j;
                            maxSequence[i].Length = maxSequence[j].Length + 1;
                            maxSequence[i].Sum = maxSequence[j].Sum + plants[i];
                        }
                    }
                }
            }
        }
    }
}
