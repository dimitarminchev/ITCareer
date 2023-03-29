namespace SumNumbers
{
    class Program
    {
        /// <summary>
        /// Sum Numbers
        /// https://judge.softuni.org/Contests/Practice/Index/597#1
        /// </summary>
        static void Main(string[] args)
        {
            Func<int[]> input = () => Console.ReadLine()
                   .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse).ToArray();

            int[] numbers = input();

            // count
            Func<int[], int> count = (nums) => nums.Count();
            Console.WriteLine(count(numbers));

            // sum
            Func<int[], int> sum = (nums) => nums.Sum();
            Console.WriteLine(sum(numbers));
        }
    }
}