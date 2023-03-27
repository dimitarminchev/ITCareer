namespace Rainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            input.RemoveAt(input.Count - 1);
            List<int> original = new List<int>();
            var steps = 0;
            foreach (var re in input)
            {
                original.Add(re);
            }
            int indexnow = input.Last();
            for (int i = 0; i < input.Count; i++)
            {
                input[i]--;
            }
            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                steps++;
                for (int i = 0; i < input.Count; i++)
                {
                    input[i]--;
                }
                if (input[a] == 0)
                {
                    Console.WriteLine(string.Join(" ", input));
                    Console.WriteLine(steps);
                    break;
                }
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == 0)
                    {
                        input[i] = original[i];
                    }
                }
            }
        }
    }
}