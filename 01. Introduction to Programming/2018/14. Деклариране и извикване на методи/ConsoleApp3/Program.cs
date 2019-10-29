using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        // 03. Принтиране на триъгълник
        static void PrintLine(int n)
        {
            for (int i = 1; i <= n; i++)  Console.Write("{0} ", i);
            Console.WriteLine();
        }

        // Главен метод
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) PrintLine(i);
            for (int i = n-1; i >= 1; i--) PrintLine(i);
        }
    }
}
