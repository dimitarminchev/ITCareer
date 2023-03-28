namespace ArrayMajor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int res = list.Where(x => list.Count(c => c == x) >= list.Count() / 2 + 1).ToList().Distinct().FirstOrDefault();
            if (res != 0) Console.WriteLine(res);
            else Console.WriteLine("The majorant does not exists!”.");
        }
    }
}