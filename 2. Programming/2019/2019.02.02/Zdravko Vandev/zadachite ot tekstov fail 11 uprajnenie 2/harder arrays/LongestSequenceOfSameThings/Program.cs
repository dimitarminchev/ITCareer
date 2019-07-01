using System;
using System.Linq;

namespace LongestSequenceOfSameThings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Зеленото е буквално всичко, което трябва да се промени за да се получи другата задача
            uint[] arr = Console.ReadLine().Split(' ').Select(uint.Parse).ToArray();
            uint longestSequence = 0, bestNumber=0;
            for (int i = 0; i < arr.Length; i++)
            {
                uint currentSequence = 1;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i]) //if (arr[j] == arr[i]+currentSequence)                                     
                        currentSequence++;                
                    else
                        break;
                }
                if (currentSequence>longestSequence)
                {
                    longestSequence = currentSequence;
                    bestNumber = arr[i];
                }
            }
            for (int i = 0; i < longestSequence; i++)
                Console.Write($"{bestNumber} "); //$"{bestNumber++} "
        }
    }
}
