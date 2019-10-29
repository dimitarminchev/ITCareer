using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FiveSpecialLetters
{
    internal class Program
    {

        private static int letterWeight(char input)
        {
            if (input == 'a') return 5;
            if (input == 'b') return -12;
            if (input == 'c') return 47;
            if (input == 'd') return 7;
            if (input == 'e') return -32;
            return 0;
        }

        private static int weight(char[] input)
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

        private static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            List<string> output = new List<string>();

            // new
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    for (int c = 0; c < 5; c++)
                    {
                        for (int d = 0; d < 5; d++)
                        {
                            for (int e = 0; e < 5; e++)
                            {
                                char letterA = (char)('a' + a);
                                char letterB = (char)('a' + b);
                                char letterC = (char)('a' + c);
                                char letterD = (char)('a' + d);
                                char letterE = (char)('a' + e);
                                char[] word = new char[]
                                {
                                        letterA,
                                        letterB,
                                        letterC,
                                        letterD,
                                        letterE
                                };

                                int weightOfWord = weight(word);
                                if (start <= weightOfWord && weightOfWord <= end)
                                {
                                   output.Add(new string(word));
                                }
                            }
                        }
                    }
                }
            }

            // old
            // char[] words = { 'a', 'a', 'a', 'a', 'a' };
            // int[] interator = new int[5];
            //while (true)
            //{
            // int weightOfWord = weight(words);
            // if (start <= weightOfWord && weightOfWord <= end)
            // {
            //     output.Add(new string(words));
            // }

            //if (interator[0] < 5) LetterChange(words, interator, 0);
            //else
            //{
            //    if (interator[1] < 5) LetterChange(words, interator, 1);
            //    else
            //    {
            //        if (interator[2] < 5) LetterChange(words, interator, 2);
            //        else
            //        {
            //            if (interator[3] < 5) LetterChange(words, interator, 3);
            //            else
            //            {
            //                if (interator[4] < 5) LetterChange(words, interator, 4);
            //                else break;
            //                interator[3] = 0;
            //            }
            //            interator[2] = 0;
            //        }
            //        interator[1] = 0;
            //    }
            //    interator[0] = 0;
            //}
            //}

            if (output.Count != 0)
            {
                output.Sort();

                for (int i = 0; i < output.Count; i++)
                {
                    if (i + 1 != output.Count)
                    {
                        if (output[i] == output[i + 1])
                        {
                            output.RemoveAt(i);
                            i--;
                        }
                    }
                }

                foreach (var item in output)
                {
                    Console.Write(item + " ");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        //// new
        //private static void LetterChange(char[] words, int[] interator, int index)
        //{
        //    words[index] = (char)((int)'a' + interator[index]);
        //    interator[index]++;
        //}
    }
}
