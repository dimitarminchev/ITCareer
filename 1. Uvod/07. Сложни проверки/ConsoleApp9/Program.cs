using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9. Кино
            var type = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            // Проверки
            double sum = rows * cols;
            if (type == "premiere") sum *= 12.00;
            if (type == "normal") sum *= 7.50;
            if (type == "discount") sum *= 5.00;
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
