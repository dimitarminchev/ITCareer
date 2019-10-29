using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
/* 10. Почивни дни между две дати
Имате задачата да откриете и поправите грешките във вече написан програмен код, като използвате дебъгера на Visual Studio. За целта трябва да проследите изпълнението на програмата, за да откриете тези редове от кода ѝ, които пораждат неправилен или неочакван резултат.
Решение: Петко Люцканов и Божидар Андонов
*/
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) { holidaysCount++; }
            }
            Console.WriteLine(holidaysCount);
        }
    }
}
