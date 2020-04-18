using System;

namespace _09_Abstraction
{
    class Program
    {
        static void Main()
        {
            // Circle Demo
            Circle circle = new Circle(5);
            circle.PrintInformation();

            // Rectangle Demo
            Rectangle rect = new Rectangle(2, 3);
            rect.PrintInformation();
        }
    }
}
