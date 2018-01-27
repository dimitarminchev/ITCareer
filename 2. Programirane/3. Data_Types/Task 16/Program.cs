using System;

namespace Task_16
{
/* 16. Поздрав
Напишете програма, която въвежда първото име, последното име и възрастта и извежда "Hello, <first name> <last name>. You are <age> years old.". Използвайте съставни низове.
*/
    class Program
    {
        // Решение: Христо Димитров
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            object hello = name + " " + surName;
            Console.WriteLine("Hello {0}. You are {1} years old.", hello, age);
        }
    }
}
