namespace RemoveAddMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newList = new List<int>();
            newList.AddRange(list);

            int number = int.Parse(Console.ReadLine());

            if (list.Contains(number)) list.Remove(number);
            else newList.Add(number);
            newList.Sort();

            Console.WriteLine(String.Join(" ", list));
            Console.WriteLine(String.Join(" ", newList));
        }
    }
}