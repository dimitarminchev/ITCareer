using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Точка в правоъгълник
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            // Проверки
            if((x >= x1 && x <= x2) && (y >= y1 && y <= y2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
