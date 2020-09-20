using System;
using System.Linq;
using System.Numerics;

namespace _1._Alley
{
    class Program
    {
        /*
        Задача 1. Алеа
        ---
        Алея в градската градина на град X има дължина L и трябва да бъде павирана с правоъгълни плочи. 
        Всяка плоча има ширина, колкото алеята, но дължините на плочите са различни. 
        Плочите са N вида и видовете са номерирани от 1 до N. Разполагаме с достатъчно плочи от всеки вид. 
        Определете по колко различни начина може да се павира алеята, като се използват съществуващите 
        видове плочи.
        На първия ред на стандартния вход се  въвеждат две положителни цели числа, разделени с интервал - L,  
        дължината на алеята и N - броят на видовете плочи. На  втория ред се въвеждат N на брой 
        положителни цели числа, разделени с интервал, d1 d2 ... dn, където di е равно на 
        дължината на плочата от вид i, i = 1, ..., N.
        Програмата да извежда едно положително цяло число, равно на броя начини, по които алеята може да павира.
 
        Вход:
        5 3
        2 1 3
        Изход:
        13
        */

        static BigInteger counter = 0;
        static int[] sizes;

        static void Solve(int length)
        {
            if (length == 0)
            {
                counter++;
                return;
            }
            else if (length > 0)
            {
                for (int i = 0; i < sizes.Length; i++)
                {
                    if (length - sizes[i] >= 0)
                    {
                        Solve(length - sizes[i]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var length = input[0];
            sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Solve(length);
            Console.WriteLine(counter);
        }
    }
}
