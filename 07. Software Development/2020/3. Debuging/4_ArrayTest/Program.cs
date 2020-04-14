using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ArrayTest
{
    public static class Console
    {
        public static void Write(string s )
        {
            var fgColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(s);
            System.Console.ForegroundColor = fgColor;
        }
    }

    class Program
    {

        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(System.Console.ReadLine());

            long[] array = System.Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string[] command = System.Console.ReadLine().Split(ArgumentsDelimiter).ToArray();

            while (!command[0].Equals("stop"))
            {
                int[] args = new int[2];

                if (command[0].Equals("add") ||
                    command[0].Equals("subtract") ||
                    command[0].Equals("multiply"))
                {
                    string[] stringParams = command;
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);
                }

                PerformAction(array, command[0], args);

                PrintArray(array);
                System.Console.WriteLine();

                command = System.Console.ReadLine().Split(ArgumentsDelimiter).ToArray();
            }
        }

        static void PerformAction(long[] array, string action, int[] args)
        {
            int pos = args[0]-1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long last = array[array.Count() - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = last;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long first = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Count() - 1] = first;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write((array[i] + " ").ToString());
            }
        }
    }
}
