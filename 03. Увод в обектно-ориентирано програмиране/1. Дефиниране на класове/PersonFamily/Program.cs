namespace PersonFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                var line = Console.ReadLine().Split();
                family.AddMember(new Person()
                {
                    Name = line[0],
                    Age = int.Parse(line[1])
                });
                n--;
            }

            family.Print();
        }
    }
}