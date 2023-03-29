namespace FloatCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }
            double element = double.Parse(Console.ReadLine());

            Console.WriteLine(box.BiggerThan(element));
        }
    }
}