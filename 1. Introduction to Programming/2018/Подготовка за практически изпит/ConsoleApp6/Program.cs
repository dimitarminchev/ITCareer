using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        // 6. Генератор за тъпи пароли 
        static void Main(string[] args)
        {
            // Входни данни
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            // Изходни данни
            for (int n1 = 1; n1 < n; n1++)
            for (int n2 = 1; n2 < n; n2++)            
            for (char l1 = 'a'; l1 < 'a'+l; l1++)
            for (char l2 = 'a'; l2 < 'a'+l; l2++)
            for (int n3 = Math.Max(n1, n2) + 1; n3 <= n; n3++)
            Console.Write("{0}{1}{2}{3}{4} ", n1, n2, l1, l2, n3);
        }
    }
}
