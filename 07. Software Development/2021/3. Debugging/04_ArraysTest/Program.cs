using System.Linq;

namespace _04_ArraysTest
{
/* Input:
5
3 0 9 333 11
add 2 2
substract 1 1
multiply 3 3
stop
*/
    public class Program
    {
        // Разделител между входните данник
        private const char ArgumentsDelimiter = ' ';

        // Главна функция
        public static void Main()
        {
            // Входни данни
            int sizeOfArray = int.Parse(System.Console.ReadLine());
            long[] array = System.Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            // Изпълнение на командите
            string line = System.Console.ReadLine();
            while (!line.Equals("stop"))
            {
                string[] stringParams = line.Split(ArgumentsDelimiter);
                string command = stringParams[0];

                // Обработка на аргументи
                int[] args = new int[2];
                if (command.Equals("add") || command.Equals("substract") ||command.Equals("multiply"))
                {
                    args[0] = int.Parse(stringParams[1]) - 1; // fix: becouse it is index
                    args[1] = int.Parse(stringParams[2]);
                }
                array = PerformAction(array, command, args); 

                PrintArray(array);

                line = System.Console.ReadLine();
            }
        }

        static long[] PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr.Clone() as long[];
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "substract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }

            return array;
        }

        // WTF 1.0
        private static void ArrayShiftRight(long[] array)
        {
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
        }

        // WTF 2.0
        private static void ArrayShiftLeft(long[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
        }

        private static void PrintArray(long[] array)
        {
            Console.WriteLine(string.Join(' ',array));
        }
    }
}
