namespace LongestSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int number = 0, max = 0; // 6
            for (int i = 0; i < list.Count - 1; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j]) counter++;
                    else break;
                }
                if (counter > max)
                {
                    number = list[i];
                    max = counter;
                }
            }

            for (int i = 0; i < max; i++) result.Add(number);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}