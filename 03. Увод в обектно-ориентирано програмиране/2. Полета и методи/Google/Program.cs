namespace Google
{
    class Program
    {
        static void SetCompany(Dictionary<string, Person> people, string name, string nameOfCompany, string department, double salary)
        {
            people[name].Company.Name = nameOfCompany;
            people[name].Company.Department = department;
            people[name].Company.Salary = salary;
        }

        static void SetCar(Dictionary<string, Person> people, string name, string model, int speed)
        {
            people[name].Car.Model = model;
            people[name].Car.Speed = speed;
        }

        static void SetPokemon(Dictionary<string, Person> people, string name, string nameOfPokemon, string type)
        {
            people[name].Pokemons.Add(new Pokemon { Name = nameOfPokemon, Type = type });
        }

        static void SetParents(Dictionary<string, Person> people, string name, string nameOfParent, string birthday)
        {
            people[name].Parents.Add(new Parent { Name = nameOfParent, Birthday = birthday });
        }

        static void SetChildren(Dictionary<string, Person> people, string name, string nameOfChild, string birthday)
        {
            people[name].Children.Add(new Child { Name = nameOfChild, Birthday = birthday });
        }

        static void Output(Dictionary<string, Person> people, string name)
        {
            Console.WriteLine(name);
            Console.WriteLine("Company:");
            Console.Write(people[name].Company.ToString());
            Console.WriteLine("Car:");
            Console.Write(people[name].Car.ToString());
            Console.WriteLine("Pokemon:");
            foreach (var pokemon in people[name].Pokemons)
            {
                Console.WriteLine(pokemon.ToString());
            }
            Console.WriteLine("Parents:");
            foreach (var parent in people[name].Parents)
            {
                Console.WriteLine(parent.ToString());
            }
            Console.WriteLine("Children:");
            foreach (var child in people[name].Children)
            {
                Console.WriteLine(child.ToString());
            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            string[] line = Console.ReadLine().Split(' ').ToArray();
            while (line[0] != "End")
            {
                string command = line[1];
                string namenew = line[0];
                if (!people.ContainsKey(namenew))
                {
                    people[namenew] = new Person();
                    people[namenew].Pokemons = new List<Pokemon>();
                    people[namenew].Parents = new List<Parent>();
                    people[namenew].Children = new List<Child>();
                    people[namenew].Car = new Car();
                    people[namenew].Company = new Company();
                }
                switch (command)
                {
                    case "company":
                        SetCompany(people, line[0], line[2], line[3], double.Parse(line[4]));
                        break;
                    case "parents":
                        SetParents(people, line[0], line[2], line[3]);
                        break;
                    case "children":
                        SetChildren(people, line[0], line[2], line[3]);
                        break;
                    case "pokemon":
                        SetPokemon(people, line[0], line[2], line[3]);
                        break;
                    case "car":
                        SetCar(people, line[0], line[2], int.Parse(line[3]));
                        break;
                }
                line = Console.ReadLine().Split(' ').ToArray();
            }
            string name = Console.ReadLine();
            Output(people, name);
        }
    }
}