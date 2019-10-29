using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BoolType
{
    class Program
    {
        // 14. Булева променлива
        static void Main(string[] args)
        {
            // Четем един ред от конзолата
            string input = Console.ReadLine();

            // Преобразуваме прочетения текст в булева променлива
            bool output = Convert.ToBoolean(input);

            // Проверка и отпечатване на резилтата
            if (output == true) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
