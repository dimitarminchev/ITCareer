using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HolidaysBetweenTwoDates
{
    class Program
    {
        static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);

            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);

            var holidaysCount = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }

            Console.WriteLine(holidaysCount);
        }
    }
}
