namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Circle
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            // Rectangle
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);

            // Draw
            circle.Draw();
            rect.Draw();
        }
    }
}