namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int next = int.Parse(Console.ReadLine());
                if (capacity - next < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                capacity -= next;
            }
            Console.WriteLine(255 - capacity);
        }
    }
}