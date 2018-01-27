using System;
namespace Task_3
{
/* 3. Шестнадесетична променлива
Напишете програма, която въвежда стойност в шестнадесетичен формат (0x##) 
и я преобразува в  десетичен формат, след което извежда стойността.

*/
    class Program
    {
        // Решение: Йордан Йорданов
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(a, 16));
        }
    }
}
