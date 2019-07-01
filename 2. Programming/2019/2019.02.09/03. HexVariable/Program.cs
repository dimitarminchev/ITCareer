using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.HexVariable
{
    class Program
    {
        // 3. Шестнадесетична променлива
        static void Main(string[] args)
        {
            // Въвеждане на текстова променлива
            var input = Console.ReadLine();
            // Преобразуване на текстовата променлива в цало число
            var output = Convert.ToInt32(input, 16);
            // Печатаме резултата
            Console.WriteLine(output);
        }
    }
}
