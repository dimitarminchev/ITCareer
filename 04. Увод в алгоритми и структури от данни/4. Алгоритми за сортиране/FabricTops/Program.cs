namespace FabricTops
{
    internal class Program
    {
        public static void Swap<T>(T[] elements, int first, int second)
        {
            T temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
            Cs++;
        }

        public static bool IsLess(IComparable first, IComparable second)
        {
            Cc++;
            return first.CompareTo(second) < 0;
        }

        public static void Selection<T>(T[] elements) where T : IComparable
        {
            for (int i = 0; i < elements.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (IsLess(elements[j], elements[min]))
                    {
                        min = j;
                    }
                }
                if (i != min)
                    Swap(elements, min, i);
            }
        }

        public static int Cc = 0, Cs = 0;

        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var time = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int Tc = time[0], Ts = time[1];
            var effort = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int Ec = effort[0], Es = effort[1];
            Selection(numbers);
            Console.WriteLine($"{Cc} {Cs}");
            Console.WriteLine($"{Tc * Cc + Ts * Cs} {Ec * Cc + Es * Cs}");
        }
    }
}