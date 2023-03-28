namespace FilterOddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] counter = new int[10];
            for (int i = 0; i < counter.Length; i++)
            {
                counter[i] = 0;
            }
            for (int i = 0; i < list.Count; i++)
            {
                counter[list[i]]++;
            }

            Queue<int> queue = new Queue<int>();
            foreach (var item in list)
            {
                if (counter[item] % 2 == 0)
                {
                    queue.Enqueue(item);
                }
            }

            Console.WriteLine(string.Join(" ", queue));

            // v2
            // List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            // List<int> res = list.Where(x => list.Count(c => c == x) % 2 == 0).ToList();
            // Console.WriteLine(string.Join(" ",res));    
        }
    }
}