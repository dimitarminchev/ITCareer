namespace SaveArrayProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().ToArray();
            while (true)
            {
                var cmd = Console.ReadLine().Split().ToArray();
                switch (cmd[0])
                {
                    case "END": Console.WriteLine(string.Join(", ", array)); return;
                    case "Reverse": array = array.Reverse().ToArray(); break;
                    case "Distinct": array = array.Distinct().ToArray(); break;
                    case "Replace":
                        {
                            int index = int.Parse(cmd[1]);
                            if (index < 0 || index >= array.Length) Console.WriteLine("Invalid input!");
                            else array[index] = cmd[2];
                            break;
                        }
                    default: Console.WriteLine("Invalid input!"); break;
                }
            }
        }

    }
}