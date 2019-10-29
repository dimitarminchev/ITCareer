using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.NamesList
{
    class Program
    {
        // 7. Списък с имена
        static void Main(string[] args)
        {
            // Въвеждане на списък от конзолата
            var list = Console.ReadLine().Split(',').ToList();

            // Отпечатване на списък в конзолата
            foreach (var item in list)
            {
                var parts = item.Trim().Split(' ').ToList();
                Console.WriteLine("{0} {1}", parts[1], parts[0]);
            }
        }
    }
}
