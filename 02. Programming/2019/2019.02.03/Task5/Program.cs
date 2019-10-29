using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Task 5.
Преобразувайте числата в двоична бройна система и извършете действията в двоича бройна система. 
След това преобразувайте резултата в десетична бройна система
*/
namespace Task5
{
    class Program
    {
        // Функция за обръщане на текст
        static string StringReverse(string str)
        {
            string result = string.Empty;
            for (var i = str.Length - 1; i >= 0; i--)
                result += str[i];
            return result;
        }

        // Конвертиране на десетично в двоично
        static string dec2bin(int n)
        {
            string result = string.Empty;
            while (n > 0)
            {
                result += (n % 2);
                n = n / 2;
            }
            return StringReverse(result);
        }

        // Конвертиране от двоично в десетично
        static int bin2dec(string bin)
        {
            int result = 0, pow = 0;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                var A = int.Parse(bin[i].ToString());
                result += (int)(A * Math.Pow(2, pow));
                pow++;
            }
            return result;
        }

        // Сумиране на две двоични числа
        static string binplus(string bin1, string bin2)
        {           
            // уеднаквяване на дължината на двете числа
            if (bin1.Length > bin2.Length)
            {
                int zeros = bin1.Length - bin2.Length;
                bin2 = new string('0', zeros) + bin2;
            }
            if (bin2.Length > bin1.Length)
            {
                int zeros = bin2.Length - bin1.Length;
                bin1 = new string('0', zeros) + bin1;
            }
            // сумиране
            string bin3 = string.Empty;
            char extraone = '0';
            for (var i = bin1.Length - 1; i >= 0; i--)
            {
                int ones = int.Parse(bin1[i].ToString()) 
                         + int.Parse(bin2[i].ToString()) 
                         + int.Parse(extraone.ToString());
                switch (ones)
                {
                    case 0: { bin3 += '0'; extraone = '0'; break; }
                    case 1: { bin3 += '1'; extraone = '0'; break; }
                    case 2: { bin3 += '0'; extraone = '1'; break; }
                    case 3: { bin3 += '1'; extraone = '1'; break; }
                }                
            }
            bin3 = StringReverse(bin3);
            if (extraone == '1') bin3 = '1' + bin3;
            return bin3;
        }

        // Главна програма
        static void Main(string[] args)
        {
            // 12 + 15 = 27
            Console.WriteLine("{0} (10) + {1} (10) = {2} (10)",
            12, 15, bin2dec(binplus(dec2bin(12), dec2bin(15))));

            Console.WriteLine("{0} (2) + {1} (2) = {2} (2)",
            dec2bin(12), dec2bin(15), binplus(dec2bin(12), dec2bin(15)));

            // Empty Line
            Console.WriteLine("---");

            // 9 + 15 = 24
            Console.WriteLine("{0} (10) + {1} (10) = {2} (10)",
            9, 15, bin2dec(binplus(dec2bin(9), dec2bin(15))));

            Console.WriteLine("{0} (2) + {1} (2) = {2} (2)",
            dec2bin(9), dec2bin(15), binplus(dec2bin(9), dec2bin(15)));

        }
    }
}
