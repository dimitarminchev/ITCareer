namespace FoodShortages
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rebel> rebels = new List<Rebel>();
            List<Citizen> citizens = new List<Citizen>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            { 
                var line = Console.ReadLine().Split().ToArray();
                if (line.Count() == 4)
                {
                    rebels.Add(new Rebel(line[0], line[2], int.Parse(line[1])));
                }
                else citizens.Add(new Citizen(line[0], int.Parse(line[1]), line[2], line[3]));
                line = Console.ReadLine().Split().ToArray();
            }
            string s = Console.ReadLine();
            int food = 0;
            while(s!="End")
            {
                if (rebels.Select(x => x.Name).Where(x => x == s).Count() != 0) food += 5;
                else if(citizens.Select(x => x.Name).Where(x => x == s).Count() != 0) food += 10;
                s = Console.ReadLine();
            }
            Console.WriteLine(food);
        }
    }
}
