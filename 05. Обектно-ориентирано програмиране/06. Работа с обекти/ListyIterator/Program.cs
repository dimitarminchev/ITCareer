namespace ListyIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> list = new ListyIterator<string>();
            var line = Console.ReadLine().Split().ToArray();
            while (line[0] != "END")
            {
                switch (line[0])
                {
                    case "PrintAll":
                        list.PrintAll();
                        break;
                    case "Create":
                        list.Create(line.Skip(1).ToArray());
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "Print":
                        Console.WriteLine(list.Print());
                        break;
                }
                line = Console.ReadLine().Split().ToArray();
            }
        }
    }
}