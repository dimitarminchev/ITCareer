using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                ColoredFigure figure;
                switch (cmd[0])
                {
                    case "Triangle":
                    {
                            figure = new Triangle(cmd[1], int.Parse(cmd[2]));
                            break;
                    }
                    case "Circle":
                    {
                            figure = new Circle(cmd[1], int.Parse(cmd[2]));
                            break;
                    }
                    default:
                     {
                            figure = new Square(cmd[1], int.Parse(cmd[2]));
                            break;
                     }
                }
                // Печат на инфоррмация
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0}:", cmd[0]);
                figure.Show();
                Console.WriteLine("Area: {0}", figure.GetArea());
                Console.ResetColor();

            }
        }
    }
}
