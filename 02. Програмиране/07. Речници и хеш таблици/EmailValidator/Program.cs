namespace EmailValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // v1
            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();
                if (commands[0] == "stop")
                {
                    break;
                }
                string emails = Console.ReadLine();
                string names = (string.Join(" ", commands));
                if (emails.Contains("bg") && commands[0] != "stop")
                {
                    Console.WriteLine("{0} -> {1}", names, emails);
                }
            }

            // v2
            var emails = new Dictionary<string, string>();
            int row = 1;
            string line = Console.ReadLine();
            string name = line;
            while (line != "stop")
            {
                if (row % 2 == 0)
                {
                    emails[name] = line;
                }
                else
                {
                    name = line;
                }
                line = Console.ReadLine();
                row++;
            }
            foreach (var pair in emails)
            {
                if (!(pair.Value.ToLower().Contains("us") || pair.Value.ToLower().Contains("uk")))
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }
            }
        }
    }
}