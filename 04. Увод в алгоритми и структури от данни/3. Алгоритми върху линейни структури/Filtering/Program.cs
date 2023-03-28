namespace Filtering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            foreach (var item in list)
            {
                if (item > 0)
                {
                    queue.Enqueue(item);
                }
            }

            Console.WriteLine(string.Join(" ", queue));
        }
    }
}