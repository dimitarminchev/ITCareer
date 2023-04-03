/// <summary>
/// Refactoring task "FiveSpecialLetters" namespace.
/// </summary>
namespace FiveSpecialLetters
{
    /// <summary>
    /// Refactoring task "FiveSpecialLetters" main program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Max Letters is Five.
        /// </summary>
        public const int maxLetters = 5;

        /// <summary>
        /// Calculate letter weight
        /// </summary>
        /// <param name="input">Letter</param>
        /// <returns>Weight</returns>
        private static int letterWeight(char input)
        {
            switch (input)
            {
                case 'a': return 5;
                case 'b': return -12;
                case 'c': return 47;
                case 'd': return 7;
                case 'e': return -32;
                default:
                    throw new ArgumentOutOfRangeException("Out Of range");
            }
        }

        /// <summary>
        /// Calculate word weight
        /// </summary>
        /// <param name="input">Word</param>
        /// <returns>Weight</returns>
        private static int wordWeight(char[] input)
        {
            List<char> word = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                word.Add(input[i]);
            }

            for (int i = 0; i < word.Count; i++)
            {
                for (int j = i + 1; j < word.Count; j++)
                {
                    if (word[i] == word[j])
                    {
                        word.RemoveAt(j);
                        j--;
                    }
                }
            }

            int output = 0;

            for (int i = 0; i < word.Count; i++)
            {
                output += (i + 1) * letterWeight(word[i]);
            }
            return output;
        }

        /// <summary>
        /// Refactoring task "FiveSpecialLetters" main program method.
        /// </summary>
        /// <param name="args">No arguments needed.</param>
        public static void Main(string[] args)
        {
            // input
            int minWeight = int.Parse(Console.ReadLine());
            int maxWeight = int.Parse(Console.ReadLine());

            // var 
            char currentChar = 'a';
            char[] currentWord = { currentChar, currentChar, currentChar, currentChar, currentChar };
            List<string> validWords = new List<string>();
            int[] interator = new int[maxLetters];

            // loop
            for (int i = 0; i < maxLetters; i++)
            {
                if (minWeight <= wordWeight(currentWord) && wordWeight(currentWord) <= maxWeight)
                {
                    validWords.Add(new string(currentWord));
                }

                if (interator[i] < maxLetters)
                {
                    currentWord[i] = (char)('a' + interator[i]);
                    interator[i]++;
                    i = 0;
                }
                else
                {
                    interator[i] = 0;

                    // if all words starting with the current letter are checked - go to the next letter
                    if (i == maxLetters - 1 && currentChar != 'e')
                    {
                        currentChar = (char)(currentChar + 1);
                        currentWord = new[] { currentChar, currentChar, currentChar, currentChar, currentChar };
                        i = 0;
                    }
                }
            }

            // Final Check and Output
            if (validWords.Count != 0)
            {
                validWords.Sort();
                validWords = validWords.Distinct().ToList();
                Console.WriteLine(string.Join(" ", validWords));
            }
            else
            {
                Console.WriteLine("No words found!");
            }
        }

    }
}