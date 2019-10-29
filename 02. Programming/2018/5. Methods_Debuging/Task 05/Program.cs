using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
/* 5. Конвертор за температури
Създайте метод, който конвертира температура от Фаренхайт в Целзий. Форматирайте резултата до втория десетичен знак.
Използвайте формулата: (fahrenheit - 32) * 5 / 9.
Решение: Владимир Владимиров
*/
    class Program
    {
        static double For(double F)
        {
            return (F - 32) * 5 / 9;
        }

        static void Main(string[] args)
        {
            double n;
            n = For(double.Parse(Console.ReadLine()));
            Console.Write("Celsius=");
            Console.WriteLine("{0:f2}", n);
        }
    }
}
}
