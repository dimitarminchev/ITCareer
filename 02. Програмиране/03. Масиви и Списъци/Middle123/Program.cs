namespace Middle123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int len = nums.Length;

            if (len == 1) nums = nums.Take(1).ToArray();
            else if (len % 2 == 0) nums = nums.Skip(len / 2 - 1).Take(2).ToArray();
            else nums = nums.Skip(len / 2 - 1).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}