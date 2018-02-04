using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
/* 9. Умножаване на големи числа
Входните данни са два реда – на първия се въвежда голямо число (от 0 до 1050). На втория - едноцифрено число (0-9). Трябва да се изведе произведението на тези числа.
Решение: Димитър Минчев
*/
    class Program
    {
        // Умножение
        static String Multiply(String BigNumber, int Multiplyer)
        {
            String Result = String.Empty;
            int j = 0, Reminder = 0;
            for (int i = BigNumber.Length - 1; i >= 0; i--)
            {
                int Current = Multiplyer * ((int)BigNumber[i] - 48); // ASCII
                if (Reminder > 0)
                {
                    Current += Reminder;
                    Reminder = 0;
                }
                if (Current > 9)
                {
                    Reminder = Current / 10;
                    Current = Current % 10;
                }
                Result += Current.ToString();
                j++;
            }

            // За големи числа този код не е достатъчен!
            if(Reminder > 0) Result += string.Join("", Reminder.ToString().Reverse());

            return string.Join("", Result.Reverse());
        }

        static void Main(string[] args)
        {
            String BigNumber = Console.ReadLine();
            int Multiplyer = int.Parse(Console.ReadLine());
            Console.Write( Multiply(BigNumber,Multiplyer));
        }
    }
}
