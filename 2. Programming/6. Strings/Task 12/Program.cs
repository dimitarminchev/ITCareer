using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
/* 12. Само букви
Напишете програма, която въвежда низ съобщение като вход и замества всички числа с буквата непосредствено след числото.
Решение: Павел Недков
*/
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string last = "", result = "";
            for (int i = line.Length - 1; i >= 0; i--)
            {
                var c = (int)line[i];
                if (c >= 48 && c <= 57)
                {
                    if (last != "") result += last;
                    else result += line[i].ToString();
                }
                else
                {
                    last = line[i].ToString();
                    result += line[i].ToString();
                }
            }
            Console.WriteLine(string.Join("", result.Reverse()));
        }
    }
}
