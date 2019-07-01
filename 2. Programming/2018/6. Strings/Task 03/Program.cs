using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
/* 3. Обръщане на низ
Създайте метод, който получава низ и връща низ, получен от същите символи, но в обратен ред.
Решение: Владимир Владимиров
*/
    class Program
    {
        static string Reverse(string array)
        {
            string reverse = String.Empty;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverse += array[i];
            }
            return reverse;
        }

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Console.WriteLine(Reverse(line));
        }
    }
}
