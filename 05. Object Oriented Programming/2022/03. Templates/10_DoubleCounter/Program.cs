namespace _10_DoubleCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();

            // Input
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }
            double element = double.Parse(Console.ReadLine());

            // Output
            Console.WriteLine(box.BiggerThan(element));
        }
    }
}