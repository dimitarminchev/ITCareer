namespace FilterByAge
{
    class Program
    {
        /// <summary>
        /// Filter By Age
        /// https://judge.softuni.org/Contests/Practice/Index/597#4
        /// </summary>
        static void Main(string[] args)
        {

            Dictionary<string, int> people = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                people.Add(input[0], int.Parse(input[1]));
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<int, bool> tester = CreateTester(condition, age);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);
            PrintFilteredStudent(people, tester, printer);
        }

        public static Func<int, bool> CreateTester(string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x < age;
                case "older": return x => x >= age;
                default: return null;
            }
        }

        public static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return person => Console.WriteLine($"{person.Key}");
                case "age":
                    return person => Console.WriteLine($"{person.Value}");
                case "name age":
                    return person =>
                       Console.WriteLine($"{person.Key} - {person.Value}");
                default: return null;
            }
        }

        public static void PrintFilteredStudent
        (
            Dictionary<string, int> people,
            Func<int, bool> tester,
            Action<KeyValuePair<string, int>> printer
        )
        {
            foreach (var person in people)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
            }
        }
    }
}