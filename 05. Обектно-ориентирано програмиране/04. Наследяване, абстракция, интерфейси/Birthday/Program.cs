namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Robot> robots = new List<Robot>();
            List<Citizen> citizens = new List<Citizen>();
            List<Pet> pets = new List<Pet>();
            var line = Console.ReadLine().Split().ToArray();
            while (line.Count() > 1)
            {
                switch (line[0])
                {
                    case "Citizen": citizens.Add(new Citizen(line[1], int.Parse(line[2]), line[3],line[4]));break;
                    case "Robot": robots.Add(new Robot(line[2], line[1]));break;
                    case "Pet": pets.Add(new Pet(line[1], line[2]));break;
                }
                
                line = Console.ReadLine().Split().ToArray();
            }
            string searching = Console.ReadLine();
            Console.WriteLine(string.Join("\n", pets.Select(x => x.BirthDate).ToArray().Where(x => x.Substring(x.Length - 4, 4) == searching).ToArray()));
            Console.WriteLine(string.Join("\n", citizens.Select(x => x.birthDate).ToArray().Where(x => x.Substring(x.Length - 4, 4) == searching).ToArray()));
        }
    }
}
