namespace ComparablePerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            while (true)
            {
                var cmd = Console.ReadLine().Split().ToArray();
                if (cmd[0] == "END") break;
                people.Add(new Person(cmd[0], int.Parse(cmd[1]), cmd[2]));
            }

            int n = int.Parse(Console.ReadLine());
            Person searched = people[n - 1];
            int matches = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(searched) == 0)
                {
                    matches++;
                }
            }
            if (matches != 1)
            {
                Console.WriteLine($"{matches} {people.Count - matches} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}