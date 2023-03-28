namespace ListAverrageAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine("Sum = {0}", list.Sum());
            Console.WriteLine("Average = {0}", list.Average());
        }
    }
}