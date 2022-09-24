namespace _09_StringCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            // Input
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }
            string element = Console.ReadLine();

            // Output
            Console.WriteLine(box.BiggerThan(element));
        }
    }
}