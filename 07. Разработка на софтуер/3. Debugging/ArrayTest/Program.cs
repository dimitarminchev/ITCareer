namespace ArrayTest
{
    public class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string[] command = Console.ReadLine().Split(ArgumentsDelimiter).ToArray();

            while (!command[0].Equals("stop"))
            {
                int[] args = new int[2];

                if (command[0].Equals("add") ||
                    command[0].Equals("subtract") ||
                    command[0].Equals("multiply"))
                {
                    args[0] = int.Parse(command[1]);
                    args[1] = int.Parse(command[2]);
                }

                array = PerformAction(array, command[0], args);

                PrintArray(array);

                command = Console.ReadLine().Split(ArgumentsDelimiter).ToArray();
            }
        }

        static long[] PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr.Clone() as long[];
            int pos = args[0] - 1;
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
                    array = ArrayShiftLeft(array);
                    break;
                case "rshift":
                    array = ArrayShiftRight(array);
                    break;
            }

            return array;
        }

        private static long[] ArrayShiftRight(long[] array)
        {
            long movingElement = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = movingElement;
            return array;
        }

        private static long[] ArrayShiftLeft(long[] array)
        {
            long movingElement = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = movingElement;
            return array;
        }

        private static void PrintArray(long[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}