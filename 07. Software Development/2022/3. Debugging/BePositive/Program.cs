namespace BePositive
{
    using System.Collections.Generic;

    internal class Program
    {
        public static void Main()
        {
            int countSequences = int.Parse(System.Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = System.Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                List<int> numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    int num = int.Parse(input[j]);
                    numbers.Add(num);
                }

                bool possitiveFound = false;
                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];
                    if (currentNum >= 0)
                    {
                        possitiveFound = true;
                        Console.Write(currentNum + " ");
                    }
                    else
                    {
                        currentNum += numbers[j + 1];
                        if (currentNum >= 0)
                        {
                            possitiveFound = true;
                            Console.Write(currentNum + " ");
                        }
                        j++;
                    }
                }
                if (!possitiveFound)
                {
                    Console.Write("(empty)");
                }
                System.Console.WriteLine();
            }
        }

    }
}