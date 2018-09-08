using System;
using System.Linq;

namespace _715
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int[]> Add = n => n.Select(x => x += 1).ToArray();
            Func<int[], int[]> Multiply = n => n.Select(x => x *= 2).ToArray();
            Func<int[], int[]> Subtract = n => n.Select(x => x -= 1).ToArray();
            Action<int[]> Print = n => Console.WriteLine(string.Join(" ", n));

            string command = Console.ReadLine();
            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = Add(numbers);
                        break;
                    case "multiply":
                        numbers = Multiply(numbers);
                        break;
                    case "subtract":
                        numbers = Subtract(numbers);
                        break;
                    default:
                        Print(numbers);
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
