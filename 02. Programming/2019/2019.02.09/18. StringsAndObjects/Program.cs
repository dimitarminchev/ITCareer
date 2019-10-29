using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.StringsAndObjects
{
    class Program
    {
        // 18. Низове и обекти
        static void Main(string[] args)
        {
            string lineI = Console.ReadLine();
            string lineII = Console.ReadLine();
            object merge = lineI + " " + lineII;
            Console.WriteLine(merge);
        }
    }
}
