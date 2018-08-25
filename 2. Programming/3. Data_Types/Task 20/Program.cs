using System;

namespace Task_20
{
/* 20. Данни на служител
Маркетинг компания иска да пази информация за служителите си. Всеки запис съдържа следната информация:
- Име
- Фамилия
- Възраст (0...100)
- Пол (m или f)
- ЕГН (e.g. 8306112507)
- Уникален номер на служителя (27560000…27569999)
Декларирайте променливите неоходими да се пази информацията за един служител използвайки подходящи типове данни. 
Използвайте описателни имена. Изведете данните на конзолата. 
*/
    class Program
    {
        // Решение: Павел Недков
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string Years = Console.ReadLine();
            string gender = Console.ReadLine();
            string personalID = Console.ReadLine();
            string employeeNumber = Console.ReadLine();

            Console.WriteLine($"First name : {firstName}");
            Console.WriteLine($"Last name : {lastName}");
            Console.WriteLine($"Age : {Years}");
            if (gender == "f")
            {
                Console.WriteLine($"Gender : f ");
            }
            else if (gender == "m") 
            {
                Console.WriteLine($"Gender : m ");
            }
            Console.WriteLine($"Personal ID : {personalID}");
            Console.WriteLine($"Unique Employee number : {employeeNumber}");
        }
    }
}
