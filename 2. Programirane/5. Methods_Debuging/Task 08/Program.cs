using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08
{
/* 8. По-голямата от две стойности
Имате подадени като входни данни две стойности от един и същи тип. Стойностите може да са от тип int, char или string. Създайте метод GetMax() който връща по-голямата от двете стойности.
Решение: Живко Колев и Йордан Йорданов
*/
    class Program
    {
        static int Max(int first, int second)
        {
            if (first > second) return first;
            else return second;
        }
        static char Max(char first, char second)
        {
            if (first > second) return first;
            else return second;

        }
        static string Max(string first, string second)
        {
            if (first.Length > second.Length) return first;
            else return second;

        }

        static void Main(string[] args)
        {
            string funkciq = Console.ReadLine();
            if (funkciq == "int")
            {

                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(Max(first, second));
            }
            else if (funkciq == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(Max(first, second));
            }
            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(Max(first, second));
            }
        }
    }
}
