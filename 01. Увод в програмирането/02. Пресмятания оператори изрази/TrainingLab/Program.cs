namespace TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine()) * 100;
            var h = double.Parse(Console.ReadLine()) * 100;

            var w1 = (int)w / 120;
            var h1 = ((int)h - 100) / 70;
            var r = w1 * h1 - 3;

            Console.WriteLine(r);
        }
    }
}