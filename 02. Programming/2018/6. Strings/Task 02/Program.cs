using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
/* 2. Преобразуване от N-ична в 10-ична ПБС
Напишете програма, която взема N-ично число и го преобразува 10-ично число (0 до 1050), където от 2 < = N < = 10. Входът се състои от 1 ред, съдържащ две числа, разделени с един интервал. Първото число е основата N, към която трябва да преобразувате. Второто е чисото N, което трябва да се преобразува. Не използвайте никакви вградена функционалности за реобразуване, опитайте се да напишете свой собствен алгоритъм.
Решение: Божидар Андонов
*/
    class Program
    {
        private static int Numberin10thSystem(int numsys, int number)
        {
            int index = 0;
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10 * (int)Math.Pow(numsys, index);
                number /= 10;
                index++;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numsys = input[0];
            int number = input[1];
            Console.WriteLine(Numberin10thSystem(numsys, number));
        }
    }
}
