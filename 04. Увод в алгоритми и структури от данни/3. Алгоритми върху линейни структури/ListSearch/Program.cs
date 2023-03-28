namespace ListSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();

            int number = int.Parse(Console.ReadLine());

            if (array.Contains(number))
            {
                Console.WriteLine($"{number} Exists in the List");
            }
            else
            {
                Console.WriteLine($"{number} Not exists in the List");
            }
        }

    }
}