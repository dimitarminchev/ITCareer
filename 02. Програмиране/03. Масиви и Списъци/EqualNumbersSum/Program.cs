namespace EqualNumbersSum
{
    internal class Program
    {
        static bool HasEquals(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (HasEquals(numbers))
            {
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers.Insert(i, numbers.Skip(i).Take(2).Sum());
                        numbers.RemoveRange(i + 1, 2);
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}