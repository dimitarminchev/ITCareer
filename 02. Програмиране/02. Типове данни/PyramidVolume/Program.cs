namespace PyramidVolume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Lenght = double.Parse(Console.ReadLine());
            var Width = double.Parse(Console.ReadLine());
            var Height = double.Parse(Console.ReadLine());
            var V = (Lenght + Width + Height) / 3;
            Console.Write("Length: {0} ", Lenght);
            Console.Write("Width: {0} ", Width);
            Console.Write("Heigth: {0} ", Height);
            Console.WriteLine("Pyramid Volume: {0:F2}", V);
        }
    }
}