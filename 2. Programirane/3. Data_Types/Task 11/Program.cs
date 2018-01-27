using System;

namespace Task_11
{
/* 11.	Преобразуване на скорост
Напишете програма, която въвежда разстояние (в метри) и време (като три числа: часове, минути, секунди), и изведете скоростта, в метри за секунда, километри в час и мили в час.
Приемете, че 1 миля = 1609 метра.
*/
    class Program
    {
        // Решение: Колективно 
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var s = double.Parse(Console.ReadLine());
            var t = h * 3600 + m * 60 + s;
            var ms = n / t;
            var kmh = (n / 1000) / (t / 3600);
            var mp = (n / 1609) / (t / 3600);
            Console.WriteLine("{0:f6}", ms);
            Console.WriteLine("{0:f6}", kmh);
            Console.WriteLine("{0:f6}", mp);
        }
    }
}
