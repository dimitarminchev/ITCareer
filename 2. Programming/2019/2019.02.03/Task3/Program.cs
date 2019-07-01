using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Task 3.
Дадено е числото 111111111111111 в двоична бройна система, 
без да преобразувате числото в десетична бройна система 
определете неговата четност и запишете числото, което е :
- с 2 по-малко
- с 2 по-голямо
- 2 пъти по-голямо
*/
namespace Task3
{
    class Program
    {
        // Плюс 2
        static string plus2(string bin)
        {
            // 111111111111111 + 10 = 1000000000000001
            return '1' + new string('0', bin.Length-1) + '1';
        }
        // Минус 2
        static string minus2(string bin)
        {
            // 111111111111111 - 10 = 111111111111101
            return new string('1', bin.Length - 2) + "01";
  
        }
        // По 2
        static string multiply2(string bin)
        {
            // 111111111111111 x 10 = 1111111111111110
            return new string('1', bin.Length) + "0";
        }

        // Главна функция
        static void Main(string[] args)
        {
            string number = "111111111111111";
            Console.WriteLine("+2 = {0}", plus2(number));
            Console.WriteLine("-2 = {0}", minus2(number));
            Console.WriteLine("x2 = {0}", multiply2(number));
        }
    }
}
