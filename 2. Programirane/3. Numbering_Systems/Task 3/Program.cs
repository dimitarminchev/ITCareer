using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
/* Задача.3.	
   Дадено е числото 111111111111111 в двоична борйна система, 
   без да преобразувате числото в десетична бройна система определете неговата четност и 
   запишете числото, което е:
   - с 2 по-малко
   - с 2 по-голямо
   - 2 пъти по-голямо
*/
    class Program
    {
        // Изважда 2
        static string Minus10(string bin)
        {
            return bin;
        }

        // Добавя 2
        static string Plus10(string bin)
        {
            int EXTRA = 0;
            String PLUS10 = bin.Substring(bin.Length - 1, 1);
            for (int i = bin.Length - 2; i >= 0; i--)
            {
                // първи символ
                if (i == bin.Length - 2)
                {
                    if (bin[i] == '1')
                    {
                        PLUS10 += '0';
                        EXTRA = 1;
                    }
                    else
                    {
                        PLUS10 += '1';
                        EXTRA = 0;
                    }
                }
                // всеки следващ символ
                else
                {
                    if (bin[i] == '1' && EXTRA == 1)
                    {
                        PLUS10 += '0';
                        EXTRA = 1;
                    }
                    else
                    {
                        if (bin[i] == '1' || EXTRA == 1) PLUS10 += '1';
                        else PLUS10 += '0';
                        EXTRA = 0;
                    }
                }
            }
            if (EXTRA == 1) PLUS10 += '1';

            // Обръщане
            char[] reverse = PLUS10.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        // Удвоява числото
        static string DoubleIt(string bin)
        {
            return bin;
        }

        // Главна Функция
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Binary: ");
            String bin = Console.ReadLine();
            Console.WriteLine("Minus 10:\n{0}", Minus10(bin));
            Console.WriteLine("Plus 10:\n{0}", Plus10(bin));
            Console.WriteLine("Double:\n{0}", DoubleIt(bin));
        }
    }
}
