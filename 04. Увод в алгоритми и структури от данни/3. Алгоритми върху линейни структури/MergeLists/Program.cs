namespace MergeLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            firstList.AddRange(secondList);
            firstList.Sort();

            Console.WriteLine(String.Join(" ", firstList));
        }
    }
}