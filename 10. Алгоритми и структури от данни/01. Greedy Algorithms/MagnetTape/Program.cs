namespace MagnetTape
{
    public static class Console
    {
        public static void WriteLine<T>(T output)
        {
            var originalColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(output);
            System.Console.ForegroundColor = originalColor;
        }

        public static void Write<T>(T output)
        {
            var originalColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write(output);
            System.Console.ForegroundColor = originalColor;
        }

        public static string ReadLine() => System.Console.ReadLine();
    }

    public class Record
    {
        public int Id { get; set; }

        public int Lenght { get; set; }

        public float Probability { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Record> tape = new List<Record>();

            string[] input = Console.ReadLine().Split();
            while (input[0] != "END")
            {
                tape.Add(new Record()
                {
                    Id = int.Parse(input[0]),
                    Lenght = int.Parse(input[1]),
                    Probability = float.Parse(input[2])
                });
                input = Console.ReadLine().Split();
            }

            var result = tape.OrderByDescending(x => x.Probability / x.Lenght);

            Console.Write("Solution: ");
            Console.WriteLine(string.Join(", ", result));
        }
    }
}