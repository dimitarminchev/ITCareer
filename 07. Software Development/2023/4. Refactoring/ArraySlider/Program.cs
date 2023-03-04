/// <summary>
/// Refactoring Task "Array Slider" namespace.
/// </summary>
namespace ArraySlider
{
    /// <summary>
    /// Refactoring Task "Array Slider" main program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Refactoring Task "Array Slider" main program method.
        /// </summary>
        /// <example>
        /// Input:
        /// 1 2 3 4 5
        /// 1 + 2
        /// stop
        /// 
        /// Output: 
        /// [1, 4, 3, 4, 5]
        /// </example>
        /// <param name="args">No arguments needed.</param>
        public static void Main(string[] args)
        {
            long[] numbersCollection = Console.ReadLine()
                                     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(long.Parse)
                                     .ToArray();

            var command = Console.ReadLine().Split(' ').ToArray();
            long currentPosition = 0;

            while (command[0] != "stop")
            {
                long offset = long.Parse(command[0]);
                string operation = command[1];
                var operand = long.Parse(command[2]);
                offset %= numbersCollection.Length;
                currentPosition += offset;
                currentPosition %= numbersCollection.Length;

                if (currentPosition < 0)
                {
                    currentPosition += numbersCollection.Length;
                }
                if (currentPosition >= numbersCollection.Length)
                {
                    currentPosition -= numbersCollection.Length;
                }

                switch (operation)
                {
                    case "+":
                        if ((numbersCollection[currentPosition] + operand) < 0)
                        {
                            numbersCollection[currentPosition] = 0;
                        }
                        else
                        {
                            numbersCollection[currentPosition] = numbersCollection[currentPosition] + operand;
                        }
                        break;
                    case "-":
                        if (numbersCollection[currentPosition] < operand)
                        {
                            numbersCollection[currentPosition] = 0;
                        }
                        else
                        {
                            numbersCollection[currentPosition] = numbersCollection[currentPosition] - operand;
                        }
                        break;
                    case "*":
                        if ((numbersCollection[currentPosition] * operand) < 0)
                        {
                            numbersCollection[currentPosition] = 0;
                        }
                        else
                        {
                            numbersCollection[currentPosition] = numbersCollection[currentPosition] * operand;
                        }
                        break;
                    case "/":
                        if ((numbersCollection[currentPosition] / operand) < 0)
                        {
                            numbersCollection[currentPosition] = 0;
                        }
                        else
                        {
                            numbersCollection[currentPosition] = numbersCollection[currentPosition] / operand;
                        }
                        break;
                    case "&":
                        if ((numbersCollection[currentPosition] & operand) < 0)
                        {
                            numbersCollection[currentPosition] = 0;
                        }
                        else
                        {
                            numbersCollection[currentPosition] = numbersCollection[currentPosition] & operand;
                        }
                        break;
                    case "|":
                        if ((numbersCollection[currentPosition] | operand) < 0)
                        {
                            numbersCollection[currentPosition] = 0;
                        }
                        else
                        {
                            numbersCollection[currentPosition] = numbersCollection[currentPosition] | operand;
                        }
                        break;
                    case "^":
                        if ((numbersCollection[currentPosition] ^ operand) < 0)
                        {
                            numbersCollection[currentPosition] = 0;
                        }
                        else
                        {
                            numbersCollection[currentPosition] = numbersCollection[currentPosition] ^ operand;
                        }
                        break;
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }

            for (int index = 0; index < numbersCollection.Length; index++)
            {
                if (numbersCollection[index] < 0)
                {
                    numbersCollection[index] = 0;
                }
            }
            Console.WriteLine("[" + string.Join(", ", numbersCollection) + "]");
        }
    }
}