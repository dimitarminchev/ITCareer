using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
/* 10. Обработка на числа с представки и наставки
Наков обича математиката. Но той също се интересува от английската азбука много. Той е изобретил игра с цифри и букви от английската азбука. Играта е проста. Получавате низ, състоящ се от число между две букви. В зависимост от това дали буквата е пред числото или след него ще извършвате различни математически операции с числото за постигане на резултат.
Решение: Митко Недялков
*/
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var sum = 0d;
            foreach (var a in input)
            {
                var b = double.Parse(a.Substring(1, a.Length - 2));
                var l1 = Char.IsLower(a.First());
                var l2 = Char.IsLower(a.Last());

                b *= (l1 ? a.ToLower().First() - 96 : 1 / (a.ToLower().First() - 96));
                b += (l2 ? a.ToLower().Last() - 96 : -(a.ToLower().Last() - 96));

                sum += b;
            }
            Console.WriteLine(sum);
        }
    }
}
