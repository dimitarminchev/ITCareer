using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        // 17. Знак СТОП 
        static void Main(string[] args)
        {
            Console.BufferWidth = 1000;
            int n = int.Parse(Console.ReadLine());

            int dots = n + 1;
            var underscopes = 2 * n + 1;

            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', underscopes));
            underscopes -= 2;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', --dots), new string('_', underscopes));
                underscopes += 2;
            }

            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (underscopes - 5) / 2));
            for (int i = 0; i < n; i++)

            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', i), new string('_', underscopes));
                underscopes -= 2;
            }
        }
    }
}
