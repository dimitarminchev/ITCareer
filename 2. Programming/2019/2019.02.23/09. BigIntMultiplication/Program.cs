using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.BigIntMultiplication
{
    class Program
    {
        static string Multiply(string BigNumber, int Multiplyer)
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
            if (Reminder > 0) Result += string.Join("", Reminder.ToString().Reverse());

            return string.Join("", Result.Reverse());
        }

        static void Main(string[] args)
        {
            string BigNumber = Console.ReadLine();
            int Multiplyer = int.Parse(Console.ReadLine());
            Console.WriteLine(Multiply(BigNumber, Multiplyer));
        }
    }
}
