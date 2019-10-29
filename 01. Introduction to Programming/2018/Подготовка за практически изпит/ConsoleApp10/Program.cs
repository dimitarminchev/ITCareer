using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        // 10. Деление без остатък
        static void Main(string[] args)
        {
            int n2 = 0, n3 = 0, n4 = 0;
            int n = int.Parse(Console.ReadLine());
            float br = n;
            while(n>0)
            {
                int next = int.Parse(Console.ReadLine());
                if (next % 2 == 0) n2++;
                if (next % 3 == 0) n3++;
                if (next % 4 == 0) n4++;
                n--;
            }
            Console.WriteLine("{0:f2}%", (n2 / br) * 100);
            Console.WriteLine("{0:f2}%", (n3 / br) * 100);
            Console.WriteLine("{0:f2}%", (n4 / br) * 100);
        }
    }
}
