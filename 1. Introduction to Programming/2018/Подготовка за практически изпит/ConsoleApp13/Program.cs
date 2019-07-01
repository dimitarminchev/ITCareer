using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        // 13. Ремонт на плочки
        static void Main(string[] args)
        {
            var N = double.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = double.Parse(Console.ReadLine());
            var O = double.Parse(Console.ReadLine());

            var Обща_площ = N * N;
            var Площ_на_пейка = M * O;
            var Площ_за_покриване = Обща_площ - Площ_на_пейка;
            var Площ_за_плочки = W * L;
            var Необходими_плочки = Площ_за_покриване / Площ_за_плочки;
            var Необходимо_Време = Необходими_плочки * 0.2;

            Console.WriteLine(Необходими_плочки);
            Console.WriteLine(Необходимо_Време);
        }
    }
}
