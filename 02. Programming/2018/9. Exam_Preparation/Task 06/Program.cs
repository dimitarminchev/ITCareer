using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_06
{
    /// <summary>
    /// Task 06. Anonymous Threat (Result: 100/100)
    /// </summary>
    class Program
    {
        // Сливане
        private static void Merge(List<string> strings, int startIndex, int endIndex)
        {
            var denyStart = startIndex < 0;
            var denyEnd = endIndex >= strings.Count;
            if (denyStart) startIndex = 0;
            if (denyEnd) endIndex = strings.Count - 1;
            for (int i = startIndex; i < endIndex; endIndex--)
            {
                strings[i] = strings[i] + strings[i + 1];
                strings.RemoveAt(i + 1);
            }
        }

        // Разделяне
        private static void Divide(List<string> strings, int index, int partitions)
        {
            string currentString = strings[index];
            var lenghtOfPartitions = currentString.Length / partitions;
            var additions = new List<string>(partitions);
            for (int i = 0; i < partitions - 1; i++)
            {
                string currentAdition = currentString.Substring(0, lenghtOfPartitions);
                additions.Add(currentAdition);
                currentString = currentString.Substring(lenghtOfPartitions);
            }
            additions.Add(currentString);
            strings.RemoveAt(index);
            strings.InsertRange(index, additions);
        }

        // Главен метод
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split(' ').ToList();
            var input = new string[4];
            while ((input = Console.ReadLine().Split(' ')).First() != "3:1")
            {
                if (input.First() == "merge") Merge(strings, int.Parse(input[1]), int.Parse(input[2]));
                else if (input.First() == "divide") Divide(strings, int.Parse(input[1]), int.Parse(input[2]));
            }
            Console.WriteLine(String.Join(" ", strings));
        }       
    }
}
