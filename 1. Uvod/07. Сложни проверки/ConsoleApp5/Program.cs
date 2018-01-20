using System;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Невалидно число
            var a = long.Parse(Console.ReadLine());
            if ((a >= 100 && a <= 200) || (a == 0))
            {
                ;; // Валидно
            }
            else Console.WriteLine("invalid");
        }
    }
}
