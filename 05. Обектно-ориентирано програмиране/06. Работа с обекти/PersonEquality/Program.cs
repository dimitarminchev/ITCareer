namespace PersonEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> peopleSet = new SortedSet<Person>();
            HashSet<Person> peopleHash = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var cmd = Console.ReadLine().Split().ToArray();
                Person person = new Person(cmd[0], int.Parse(cmd[1]));

                if (peopleSet.Where(x => x.Equals(person)).Count() == 0)
                {
                    peopleSet.Add(person);
                }

                if (peopleHash.Where(x => x.GetHashCode() == person.GetHashCode()).Count() == 0)
                {
                    peopleHash.Add(person);
                }
            }

            Console.WriteLine(peopleSet.Count);
            Console.WriteLine(peopleHash.Count);
        }
    }
}