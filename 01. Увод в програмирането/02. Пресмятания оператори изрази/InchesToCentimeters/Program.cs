namespace InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches=");
            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;
            Console.Write("Centimeters = ");
            Console.WriteLine(centimeters);
        }
    }
}