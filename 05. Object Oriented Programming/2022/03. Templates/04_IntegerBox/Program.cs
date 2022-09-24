namespace _04_IntegerBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            // Input
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                box.Add(int.Parse(Console.ReadLine()));
                n--;
            }

            // Ouput
            box.Print();
        }
    }
}