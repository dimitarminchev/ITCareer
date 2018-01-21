using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
/* Задача 1.
   - Преобразувайте 1234 (10) в двоична и шестнадесетична бройна системи. 
   - Преобразувайте 1100101 (2) в десетична и шестнадесетична бройна системи. 
   - Преобразувайте ABC (16) в десетично и двоична бройна системи.
*/
    class Program
    {
        // Конвертор от десетично в двоично
        static string dec2bin(int number)
        {
            string binary = "";
            while (number > 0)
            {
                int reminder = number % 2;
                number /= 2;
                binary += reminder;
            }
            return new String(binary.ToCharArray());
        }

        // Конвертор от десетично в шестнадесетично
        static string dec2hex(int number)
        {
            string hex = "";
            while (number > 0)
            {
                int reminder = number % 16;
                number /= 16;
                hex += reminder;
            }
            return new String(hex.ToCharArray());
        }

        // Главен метод
        static void Main(string[] args)
        {
            Console.WriteLine("{0} (10) = {1} (2)",  1234, dec2bin(1234));
            Console.WriteLine("{0} (10) = {1} (16)", 1234, dec2hex(1234));
        }
    }
}
