using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.TrippleLatinLetters
{
    class Program
    {
        // 15. Тройка латински букви
        static void Main(string[] args)
        {
            // a = 0, b = 1, c = 2 .... z = 27
            int n = int.Parse(Console.ReadLine());
            // Троен вложен цикъл за генериране на тройки букви
            for (int a = 0; a < n; a++)
             for (int b = 0; b < n; b++)
              for (int c = 0; c < n; c++)
                Console.WriteLine
                (
                     "{0}{1}{2}",
                     (char)('a' + a),
                     (char)('a' + b),
                     (char)('a' + c)
                );
        }
    }
}
