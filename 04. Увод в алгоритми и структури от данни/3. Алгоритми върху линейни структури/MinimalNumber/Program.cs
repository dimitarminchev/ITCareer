namespace MinimalNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            var minimum = list.First();

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < minimum)
                {
                    minimum = list[i];
                }
            }

            Console.WriteLine(minimum);
        }
    }
}