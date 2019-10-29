using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0; int moves = 0;
            while (true)
            {
                int currentNumber = numbers[moves];
                sum += currentNumber;
                if (moves + currentNumber <= numbers.Length - 1)
                    moves += currentNumber;
                else if (moves - currentNumber >= 0)
                    moves -= currentNumber;
                else if (moves - currentNumber < 0 || moves + currentNumber > numbers.Length - 1) break;
            }
            Console.WriteLine(sum);
        }
    }
}
