using System;
namespace Task_11
{
/* 11. Списък от имена
Въведете списък от имена на хора и го изведете в конзолата в обратен ред. 
Елементите на списъка ще получите от единствен ред, разделени с интервали. 
Изведете имената на единствен ред, така че след всяко да стои знак ";".
*/
    class Program
    {
        // Решение: Димитър Минчев
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ');
            Console.WriteLine(String.Join("; ", names));
        }
    }
}
