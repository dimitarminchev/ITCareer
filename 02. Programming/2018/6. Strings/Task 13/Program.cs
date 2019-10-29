using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
/* 13. Скривалището
Вие сте детектив от Скотланд Ярд и трябва да намерите скривалището на много опасна група от престъпници. Вие ще получите карта под формата на низ и след това ще получите улики от разузнаването.
Решение: Петко Люцканов
*/
    class Program
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine();
            bool found = false;
            do
            {
                string[] positioning = Console.ReadLine().Split(' ').ToArray();
                string sign = positioning[0];
                int needed = int.Parse(positioning[1]);

                if (card.Contains(sign))
                {
                    int counter = 0;
                    int index = card.IndexOf(sign);
                    while (index != -1)
                    {
                        counter++;
                        index = card.IndexOf(sign, index + 1);
                    }
                    if (counter >= needed)
                    {
                        Console.WriteLine("Hideout found at index {0} and it is with size {1}!", card.IndexOf(sign), counter);
                        found = true;
                    }
                    else
                    {
                        found = false;
                    }
                }
            }
            while (found == false);
        }
    }
}
