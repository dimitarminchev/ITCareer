using System.Diagnostics;

namespace FastestStacker
{
    public class Program
    {
        public static Random random = new Random();

        public static void MesureTime(Action method)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            method();

            timer.Stop();
            Console.WriteLine("Time = {0} ms", timer.ElapsedMilliseconds);
        }

        public static void Main(string[] args)
        {
            const int N = 10000;
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++) numbers[i] = random.Next(0, N);

            Console.Write("Bubble Sort ... ");
            MesureTime(() => Sort.Bubble(numbers));

            Console.Write("Shuffle ... ");
            MesureTime(() => Help.Shuffle(numbers));

            Console.Write("Insertion Sort ... ");
            MesureTime(() => Sort.Insertion(numbers));
        }
    }
}