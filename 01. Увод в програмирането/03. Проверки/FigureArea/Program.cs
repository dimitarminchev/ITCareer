namespace FigureArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fig = Console.ReadLine();
            if (fig == "square")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a);
            }
            else if (fig == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            else if (fig == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI * r * r);
            }
            else
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                Console.WriteLine((a * h) / 2.0);
            
        }
    }
}