using System;

namespace Таск_14
{
/* 14.	Булева променлива
Напишете програма, която въвежда низ, преобразува го към променлива от булев тип и извежда “Yes” ако в променливата имаме true и “No” ако в променливата имаме false.
*/
    class Program
    {
        // Решение: Десислава Зойн
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Convert.ToBoolean(n);
            if (n == "True") Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
