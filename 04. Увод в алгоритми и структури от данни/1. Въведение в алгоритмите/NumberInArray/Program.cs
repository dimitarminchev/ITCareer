namespace NumberInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int number = int.Parse(Console.ReadLine());

            if (list.Contains(number)) Console.WriteLine($"{number} Exists in the List", number);
            else Console.WriteLine($"{number} Not exists in the ", number);
        }
    }
}