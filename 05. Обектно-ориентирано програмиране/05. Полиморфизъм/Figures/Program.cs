namespace Figures
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Circle
            Shape circle = new Circle(3.0);
            Console.WriteLine(circle.Draw());
            Console.WriteLine("Area = {0:f2}", circle.Area());
            Console.WriteLine("Perimeter = {0:f2}", circle.Perimeter());

            // Rectangle
            Shape rectangle = new Rectangle(3.0, 4.0);
            Console.WriteLine(rectangle.Draw());
            Console.WriteLine("Area = {0:f2}", rectangle.Area());
            Console.WriteLine("Perimeter = {0:f2}", rectangle.Perimeter());
        }
    }
}