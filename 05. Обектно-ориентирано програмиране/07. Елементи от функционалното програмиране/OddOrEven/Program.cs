namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string oddOrEven = Console.ReadLine();

            Predicate<int> evenFinder = (int p) => { return p % 2 == 0; };
            Predicate<int> oddFinder = (int p) => { return p % 2 != 0; };
            int[] result = null;

            if (oddOrEven == "odd")
            {
                result = Enumerable.Range(numbers[0], numbers[1] - numbers[0] + 1).Where(n => oddFinder(n)).ToArray();
            }
            else if (oddOrEven == "even")
            {
                result = Enumerable.Range(numbers[0], numbers[1] - numbers[0] + 1).Where(n => evenFinder(n)).ToArray();
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}