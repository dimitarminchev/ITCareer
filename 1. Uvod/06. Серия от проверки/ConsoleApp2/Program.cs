using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Бонус точки
            int n = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (n <= 100) bonus = 5;
            else if (n < 1000) bonus = n * 0.20;
            else bonus = n * 0.10;
            if (n % 2 == 0) bonus++; 
            if (n % 10 == 5) bonus += 2;
            Console.WriteLine(bonus);
            Console.WriteLine(n + bonus);
        }
    }
}
