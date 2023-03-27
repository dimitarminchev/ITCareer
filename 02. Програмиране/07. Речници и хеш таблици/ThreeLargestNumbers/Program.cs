namespace ThreeLargestNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            nums = nums.OrderByDescending(num => num).Take(3).ToArray();
            Console.Write(string.Join(" ", nums));
        }
    }
}