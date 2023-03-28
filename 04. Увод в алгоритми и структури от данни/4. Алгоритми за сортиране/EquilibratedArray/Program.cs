namespace EquilibratedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var left = arr.Take(arr.Length / 2).OrderBy(x => x).ToArray();
            var right = arr.Skip(arr.Length / 2).Take(arr.Length - arr.Length / 2).OrderByDescending(x => x).ToArray();
            Console.WriteLine(string.Join(" ", left.Concat(right).ToArray()));
        }
    }
}