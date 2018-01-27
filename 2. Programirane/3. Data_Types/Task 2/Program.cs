using System;
namespace Task_2
{
/* 2. Цели числа
Напишете програма, която присвоява цели стойности на променливи. 
Уверете се, че всяка стойност е записана в правилния тип 
(във всеки случай използвайте възможно най-икономичния тип по отношение на паметта). 
Накрая изведете всички променливи в конзолата
*/
    class Program
    {
        // Решение: Божидар Андонов 
        static void Main(string[] args)
        {
            sbyte num1 = -100;
            byte num2 = 128;
            short num3 = -3540;
            ushort num4 = 64876;
            uint num5 = 2147483648;
            int num6 = -1141583228;
            long num7 = -1223372036854775808;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);
            Console.WriteLine(num7);
        }
    }
}
