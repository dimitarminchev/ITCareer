namespace _03_StringBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            // Input
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                box.Add(Console.ReadLine());
                n--;
            }

            // Ouput
            box.Print();
        }
    }
}