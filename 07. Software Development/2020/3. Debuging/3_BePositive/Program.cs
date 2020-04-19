using System;
using System.Collections.Generic;

/// <summary>
/// 3. Debuging, 3. Be Positive
/// </summary>
namespace _3_BePositive
{

    /// <summary>
    /// Main Program Class: 3. Debuging, 3. Be Positive
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Input:
        /// 1
        /// 0 -2 2 -2 3
        /// Output:
        /// 0 0 1
        /// </summary>
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());
            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                var numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        int num = int.Parse(input[j]);
                        numbers.Add(num);
                    }
                }
                bool found = false;
                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];
                    if (currentNum >= 0)
                    {
                        if (found) Console.Write(" ");
                        Console.Write(currentNum);
                        found = true;
                    }
                    else
                    {
                        j++;
                        currentNum += numbers[j];
                        if (currentNum >= 0)
                        {
                            if (found) Console.Write(" ");
                            Console.Write(currentNum);
                            found = true;
                        }
                    }
                }
                if (!found) Console.WriteLine("(empty)");
                else Console.WriteLine();
            }
        }
    }
}
