namespace NumbersSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

            numbers = numbers.Take(command[0]).Skip(command[1]).ToList();

            if (numbers.Contains(command[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}