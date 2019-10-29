using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaxOfThings
{
    // 8. По-голямата от две стойности
    class Program
    {
        /// <summary>
        /// По-голямото от две числа
        /// </summary>
        /// <param name="first">Цяло число</param>
        /// <param name="second">Цяло число</param>
        /// <returns>Цяло число</returns>
        static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        /// <summary>
        /// По-голямото от два сиимвола
        /// </summary>
        /// <param name="first">Символ</param>
        /// <param name="second">Символ</param>
        /// <returns>Символ</returns>
        static char GetMax(char first, char second)
        {
            // Еднакъв ли трябва да е като метода за цели числа?
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        /// <summary>
        /// По-голямото от два низа
        /// </summary>
        /// <param name="first">Низ</param>
        /// <param name="second">Низ</param>
        /// <returns>Низ</returns>
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    {
                        int first = int.Parse(Console.ReadLine());
                        int second = int.Parse(Console.ReadLine());
                        int max = GetMax(first, second);
                        Console.WriteLine(max);
                        break;
                    }

                case "char":
                    {
                        char first = char.Parse(Console.ReadLine());
                        char second = char.Parse(Console.ReadLine());
                        char max = GetMax(first, second);
                        Console.WriteLine(max);
                        break;
                    }

                case "string":
                    {
                        string first = Console.ReadLine();
                        string second = Console.ReadLine();
                        string max = GetMax(first, second);
                        Console.WriteLine(max);
                        break;
                    }
            }
        }
    }
}
