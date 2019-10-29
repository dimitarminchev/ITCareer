using System;
using System.Linq;

namespace _5.ArrayTest
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))  // FIX: over => stop
            {
                string line = command.Trim(); // Console.ReadLine() => command
                int[] args = new int[2];

                string[] stringParams = line.Split(ArgumentsDelimiter);
                if (command.Contains("add") ||      // Fix: Equal => Contains
                    command.Contains("subtract") || // Fix: substract => subtract && Equal => Contains
                    command.Contains("multiply"))   // Fix: Equal => Contains
                {
                    // Fix: Moved stringParams array to allow seperation of commands  
                    args[0] = int.Parse(stringParams[1]); // FIX: 0 => 1
                    args[1] = int.Parse(stringParams[2]); // FIX: 1 => 2

                    // Fix: No need to call PerformAction() Method
                }

                PerformAction(array, stringParams[0], args); // Fix: command => stringParams[0]

                PrintArray(array);
                Console.WriteLine(); // Fix: Console.WriteLine(/n) => Console.WriteLine()
                command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            // Fix: No need to clone the array
            int pos = args[0] - 1; // Fix: args[0] => args[0] - 1
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                case "subtract":
                    arr[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long lastElement = array.Last();  // Fix: Now storing the last element of the sequence
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastElement; // Fix: We change the first element to the last one; wasn't done in the array
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long firstElement = array.First();  // Fix: Now storing the first element of the sequence
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = firstElement; // Fix: We change the last element to the first one; wasn't done in the array
        }

        private static void PrintArray(long[] array)
        {
            long lastElement = array.Last();  // Fix: Now storing the last element of the sequence
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " "); //Console.WriteLine() => Console.Write()
            }
        }
    }
}
