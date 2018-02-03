using System;

namespace Task_01
{
/* 1. Празна касова бележка
Създайте метод, който отпечатва празна касова бележка. Методът трябва да извиква три  други метода: един за отпечатване на хедъра, един за основната част на бележката и един за футъра. 
Решение: Михаил Георгиев
*/
    class Program
    {
        static void TOP()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("-----------------");
        }
        static void Middle()
        {
            Console.WriteLine("Charged to----");
            Console.WriteLine("Resived by----");
        }
        static void BOT()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
        static void Main(string[] args)
        {
            TOP();
            Middle();
            BOT();
        }
    }
}
