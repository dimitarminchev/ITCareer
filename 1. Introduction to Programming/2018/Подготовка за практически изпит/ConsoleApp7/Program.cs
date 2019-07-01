using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        // 7. Зеленчукова борса 
        static void Main(string[] args)
        {
            // Входни данни
            var VegetablesKgPrice = double.Parse(Console.ReadLine());
            var FruitsKgPrice = double.Parse(Console.ReadLine());
            var VegetablesKg = int.Parse(Console.ReadLine());
            var FruitsKg = int.Parse(Console.ReadLine());

            // Математически сметки
            var Vegetables = (VegetablesKgPrice * VegetablesKg);
            var Fruits = (FruitsKgPrice * FruitsKg);
            var WholePrice = (Vegetables + Fruits);

            // Изходни данни
            Console.WriteLine(WholePrice / 1.94);
        }
    }
}
