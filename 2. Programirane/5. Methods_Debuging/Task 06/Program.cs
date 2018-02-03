using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
/* 6. Пресмятане на лице на триъгълник
Създайте метод, който изчислява и връща лицето на триъгълник по дадени основа и височина.
Решение: Валентин Хаджиминов
*/
    class Program
    {
        static double TriangleArea(double width, double height)
        {
            return width * height / 2;
        }
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = TriangleArea(width, height);
            Console.WriteLine(area);
        }
    }
}
