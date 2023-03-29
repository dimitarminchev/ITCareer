namespace Frog
{
    internal class Program
    {
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