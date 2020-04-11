using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.ArraySlider
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberInput = Console.ReadLine();
            BigInteger[] numberInputSplitter = Regex.Split(numberInput, "\\s+").Where(n => n != "").Select(n => BigInteger.Parse(n)).ToArray();
            var command = Console.ReadLine();
            long indexInArray = 0;
            while (command != "stop")
            {
                var splittedCommands = command.Split(' ');
                var firstValue = long.Parse(splittedCommands[0]);
                var mathSymbol = splittedCommands[1];
                var secondValue = long.Parse(splittedCommands[2]);

                firstValue = firstValue % numberInputSplitter.Length;
                indexInArray += firstValue;

                var position = indexInArray % numberInputSplitter.Length;

                if (position < 0)
                {
                    position += numberInputSplitter.Length;
                }
                if (position >= numberInputSplitter.Length)
                {
                    position -= numberInputSplitter.Length;
                }
                switch (mathSymbol)
                {
                    case "+":
                        if ((numberInputSplitter[position] + secondValue) < 0)
                        {
                            numberInputSplitter[position] = 0;
                        }
                        else numberInputSplitter[position] += secondValue;
                        break;
                    case "-":
                        if (numberInputSplitter[position] < secondValue)
                        {
                            numberInputSplitter[position] = 0;
                        }
                        else numberInputSplitter[position] -= secondValue;
                        break;
                    case "*":
                        if ((numberInputSplitter[position] * secondValue) < 0)
                        {
                            numberInputSplitter[position] = 0;
                        }
                        else numberInputSplitter[position] *= secondValue;
                        break;
                    case "/":
                        if ((numberInputSplitter[position] / secondValue) < 0)
                        {
                            numberInputSplitter[position] = 0;
                        }
                        else numberInputSplitter[position] /= secondValue;
                        break;
                    case "&":
                        if ((numberInputSplitter[position] & secondValue) < 0)
                        {
                            numberInputSplitter[position] = 0;
                        }
                        else numberInputSplitter[position] &= secondValue;
                        break;
                    case "|":
                        if ((numberInputSplitter[position] | secondValue) < 0)
                        {
                            numberInputSplitter[position] = 0;
                        }
                        else numberInputSplitter[position] |= secondValue;
                        break;
                    case "^":
                        if ((numberInputSplitter[position] ^ secondValue) < 0)
                        {
                            numberInputSplitter[position] = 0;
                        }
                        else numberInputSplitter[position] ^= secondValue;
                        break;
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < numberInputSplitter.Length; i++)
            {
                if (numberInputSplitter[i] < 0)
                {
                    numberInputSplitter[i] = 0;
                }
            }
            Console.WriteLine("[" + string.Join(", ", numberInputSplitter) + "]");
        }
    }
}
