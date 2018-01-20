using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        // 3. Навреме за изпит 
        static void Main(string[] args)
        {
            // Входни данни: начало на изпита и пристигане на студента
            int h1 = int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            int h2 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());

            // Формираме на датите и разликата между тях
            DateTime dt1 = Convert.ToDateTime(h1 + ":" + m1);
            DateTime dt2 = Convert.ToDateTime(h2 + ":" + m2);
            TimeSpan span = dt2.Subtract(dt1);
            int m = span.Minutes;
            int h = span.Hours;

            // Проверки
            if (m < -30) Console.WriteLine("Early");
            else if (m >= -30 && m <= 0) Console.WriteLine("On time");
            else if (m > 0 || h > 0) Console.WriteLine("Lаte");

            if (h <= -1) Console.WriteLine("{0}:{1} hours before the start", Math.Abs(h), Math.Abs(m));
            else if(m >= -59 && m <= 0) Console.WriteLine("{0} minutes before the start", Math.Abs(m));             
            else if (h >= 1) Console.WriteLine("{0}:{1} hours after the start", Math.Abs(h), Math.Abs(m));
            else if (m >= 1 && m <= 59) Console.WriteLine("{0} minutes after the start", Math.Abs(m));
            
        }
    }
}
