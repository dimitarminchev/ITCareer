namespace ArraySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int number = int.Parse(Console.ReadLine());

            if (array.Contains(number))
            {
                Console.WriteLine($"{number} Exists in the Array");
            }
            else
            {
                Console.WriteLine($"{number} Not exists in the Array");
            }
        }
    }
}