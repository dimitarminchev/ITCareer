using System;
namespace Task_4
{
/* 4. Размяна на стойности на променливи
Декларирайте две целочислени променливи a и b и им присвоете 
стойности 5 и 10 след това разменете техните стойности чрез някаква програмна логика. 
Изведете стойностите на променливите преди и след размяната, както е показано:
*/
    class Program
    {
        // Решение: Живко Колев 
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            var c = 0;

            Console.WriteLine("Before");
            Console.WriteLine(a);
            Console.WriteLine(b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("After");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
