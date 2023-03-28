namespace SportsStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] pos = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int left = pos[0] - 1, right = pos[1] - 1;
            arr = arr.OrderByDescending(x => x).ToArray();
            Console.WriteLine($"{arr[left]} {arr[right]}");
        }
    }
}