using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
/* 14. Цензора
Напишете програма, която приема като входни данни, една дума и изречение. Вашата програма трябва да търси думата в изречението и замени всяка буква от думата с "*". Вие трябва да направите това за всяко срещане на думата. Заменете само думите, които са напълно еднакви с думата на първия ред. Обърнете внимание, че трябва да се замени думата, дори ако тя е част от друга дума.
Решение: Димитър Минчев
*/
    class Program
    {
        static void Main(string[] args)
        {
            // Въвеждаме дума за цензуриране
            String Word = Console.ReadLine();

            // Заместващата дума
            String Replacement = new String('*', Word.Length);

            // Въвеждаме изречение
            String Sentance = Console.ReadLine();

            // Цензурираме
            String Replaced = Sentance.Replace(Word, Replacement);

            // Отпечатваме резултата
            Console.WriteLine(Replaced);
        }
    }
}
