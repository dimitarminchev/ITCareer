using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.HoursSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            var times = Console.ReadLine().Split()
                       .Select(x => DateTime.ParseExact(x,"HH:mm",null))
                       .ToList().OrderBy(x => x);
            // Output
            Console.WriteLine(String.Join(", ",
                       times.Select(d => d.ToString("HH:mm")).ToArray()));
        }
    }
}
