using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Въвеждане на четно число 
            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine(n); // Четно число
                        break; // Спира вечния цикъл
                    }
                }
                catch
                {
                    ;; // В случай на грешка, нищо не правим
                }
            }
        }
    }
}
