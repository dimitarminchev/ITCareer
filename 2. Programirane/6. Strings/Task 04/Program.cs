using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
/* 4. Unicode Символи
Напишете програма, която преобразува символен низ в последоватеност от Unicode символни кодове.
Решение: Живко Колев
*/
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string line = Console.ReadLine();
            foreach (var item in line) sb.Append("\\u" + ((int)item).ToString("X4"));
            Console.WriteLine(sb);
        }
    }
}
