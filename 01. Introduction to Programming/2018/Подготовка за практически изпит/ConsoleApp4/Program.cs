using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        // 4. Хистограма 
        static void Main(string[] args)
        {
            float n200 = 0, n400 = 0, n600 = 0, n800 = 0, ninf = 0;
            int n = int.Parse(Console.ReadLine());
            int br = n;
            while (n > 0)
            {
                int next = int.Parse(Console.ReadLine()); ;
                if (next < 200) n200++;
                else if (next < 400) n400++;
                else if (next < 600) n600++;
                else if (next < 800) n800++;
                else ninf++;
                n--;
            }
            Console.WriteLine("{0:f2}%", (n200 / br) * 100);
            Console.WriteLine("{0:f2}%", (n400 / br) * 100);
            Console.WriteLine("{0:f2}%", (n600 / br) * 100);
            Console.WriteLine("{0:f2}%", (n800 / br) * 100);
            Console.WriteLine("{0:f2}%", (ninf / br) * 100);
        }
    }
}
