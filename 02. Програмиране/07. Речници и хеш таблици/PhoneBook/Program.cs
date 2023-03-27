namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, string>();
            while (true)
            {
                var line = Console.ReadLine().Split(' ');
                switch (line[0])
                {
                    case "A":
                        {
                            book[line[1]] = line[2];
                            break;
                        }
                    case "S":
                        {
                            if (book.ContainsKey(line[1]))
                            {
                                Console.WriteLine("{0} -> {1}", line[1], book[line[1]]);
                            }
                            else
                            {
                                Console.WriteLine("Contact {0} does not exist.", line[1]);
                            }
                            break;
                        }
                    case "END": return;
                }
            }
        }
    }
}