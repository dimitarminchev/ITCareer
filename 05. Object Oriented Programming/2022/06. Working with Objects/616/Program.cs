namespace _616
{
    internal class Program
    {
        // 616
        static void Main(string[] args)
        {
            var a = Console.ReadLine()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

            Lake lake = new Lake(a);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}