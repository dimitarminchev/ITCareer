using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_FiveSpecialLetters
{
    class Program
    {
        /// <summary>
        /// This method returns the Letter Weight
        /// </summary>
        /// <param name="input">Single Charecter</param>
        /// <returns>Integer Value</returns>
        private static int GetLetterWeight(char input)
        {
            switch (input)
            {
                case 'a': return 5;
                case 'b': return -12;
                case 'c': return 47;
                case 'd': return 7;
                case 'e': return -32;
                default: return 0;
            }
        }

        /// <summary>
        /// This method count the Weight of a Single Word
        /// </summary>
        /// <param name="input">Single Word</param>
        /// <returns>Weight as a Integer Value</returns>
        private static int CountWeightOfWord(char[] input)
        {
            List<char> word = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                word.Add(input[i]);
            }

            word = word.Distinct().ToList();
            int weightResult = 0;
            for (int letterIndex = 0; letterIndex < word.Count; letterIndex++)
            {
                weightResult += (letterIndex + 1) * GetLetterWeight(word[letterIndex]);
            }

            return weightResult;
        }

        private const int maxLetters = 5;

        /// <summary>
        /// Main Method of the Program
        /// </summary>
        private static void Main()
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
                if (minWeight <= CountWeightOfWord(currentWord) && CountWeightOfWord(currentWord) <= maxWeight)
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

                    //if all words starting with the current letter are checked - go to the next letter
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