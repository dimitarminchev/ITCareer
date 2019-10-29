using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ColoredFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var cmd = Console.ReadLine().Split();
                switch (cmd[0])
                {
                    case "Circle":
                    {
                            Circle circle = new Circle(cmd[1], double.Parse(cmd[2]));
                            Console.WriteLine(string.Format("Name: {0}", circle.GetName()));
                            circle.Show();
                            Console.WriteLine(string.Format("Area: {0:f2}", circle.GetArea()));
                            break;
                    }
                    case "Square":
                    {
                            Square square = new Square(cmd[1], double.Parse(cmd[2]));
                            Console.WriteLine(string.Format("Name: {0}", square.GetName()));
                            square.Show();
                            Console.WriteLine(string.Format("Area: {0:f2}", square.GetArea()));
                            break;
                    }
                    case "Triangle":
                    {
                            Triangle triangle = new Triangle(cmd[1], double.Parse(cmd[2]));
                            Console.WriteLine(string.Format("Name: {0}", triangle.GetName()));
                            triangle.Show();
                            Console.WriteLine(string.Format("Area: {0:f2}", triangle.GetArea()));
                            break;
                    }
                }
            }
        }
    }
}
