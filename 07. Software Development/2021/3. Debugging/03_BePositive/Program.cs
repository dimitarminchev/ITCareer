namespace _03_BePositive
{
    using System;
    using System.Collections.Generic;

    public class BePositiveMain
    {
        public static void Main()
        {
            int countSequences = int.Parse(System.Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = System.Console.ReadLine().Trim().Split(' ');
                var numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        int num = int.Parse(input[j]); // fix: i => j
                        numbers.Add(num);
                    }
                }

                bool sumed = false;
                bool found = false;
                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];
                    if (currentNum >= 0) // fix: > => >=
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(currentNum);
                        found = true;
                    }
                    else
                    {
                        if (sumed)
                        {
                            currentNum = numbers[j];
                            sumed = false;
                        }
                        else
                        {
                            currentNum += numbers[j + 1];
                            j = j + 1;
                        }
                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(currentNum);
                            found = true;
                        }
                        else sumed = true;
                    }
                }
                if (!found)  Console.Write("(empty)");
                System.Console.WriteLine();
            }
        }
    }
}
