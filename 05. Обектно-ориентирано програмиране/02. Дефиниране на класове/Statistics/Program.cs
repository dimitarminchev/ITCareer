namespace Statistics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split().ToArray();
                family.Add(line[0], int.Parse(line[1]));
            }

            family.Print();
        }
    }
}