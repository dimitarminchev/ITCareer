using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            // Date
            DateModifier date = new DateModifier();
            date.SetDates(firstDate, secondDate);

            // Print
            Console.WriteLine(date.Difference());
        }
    }
}
