namespace SortEvenNumbers
{
    class Program
    {
        /// <summary>
        /// Sort Even Numbers
        /// https://judge.softuni.bg/Contests/Practice/Index/597#0
        /// </summary>
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                  .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(n => int.Parse(n))
                  .Where(n => n % 2 == 0)
                  .OrderBy(n => n)
                  .ToArray();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}