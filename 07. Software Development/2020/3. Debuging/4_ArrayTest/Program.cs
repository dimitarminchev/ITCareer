using System;
using System.Linq;

/// <summary>
/// 3. Debuging, 4. Array Test
/// </summary>
namespace _4_ArrayTest
{
    /// <summary>
    /// Override Console Class
    /// </summary>
    public static class Console
    {
        /// <summary>
        ///  Override Write Method
        /// </summary>
        /// <param name="s">Input Text To Print</param>
        public static void Write(string s)
        {
            var fgColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(s);
            System.Console.ForegroundColor = fgColor;
        }
    }

    /// <summary>
    /// Main Program Class: 3. Debuging, 4. Array Test
    /// </summary>
    public class Program
    {

        private const char ArgumentsDelimiter = ' ';

        /// <summary>
        /// Input:
        /// 5
        /// 3 0 9 333 11
        /// add 2 2
        /// subtract 1 1
        /// multiply 3 3
        /// stop
        /// Output:
        /// 3 2 9 333 11 
        /// 2 2 9 333 11 
        /// 2 2 27 333 11
        /// </summary>
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

        /// <summary>
        /// Perform Action
        /// </summary>
        /// <param name="array">Array</param>
        /// <param name="action">Action</param>
        /// <param name="args">Arguments</param>
        public static void PerformAction(long[] array, string action, int[] args)
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

        /// <summary>
        /// Array Shift Right
        /// </summary>
        /// <param name="array">Array</param>
        public static void ArrayShiftRight(long[] array)
        {
            long last = array[array.Count() - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = last;
        }

        /// <summary>
        /// Array Shift Left
        /// </summary>
        /// <param name="array">Array</param>
        public static void ArrayShiftLeft(long[] array)
        {
            long first = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Count() - 1] = first;
        }

        /// <summary>
        /// PrintArray
        /// </summary>
        /// <param name="array">Array</param>
        public static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write((array[i] + " ").ToString());
            }
        }
    }
}
