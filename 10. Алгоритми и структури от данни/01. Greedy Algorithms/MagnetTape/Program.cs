namespace MagnetTape
{
    /// <summary>
    /// Програма
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // Структура за данни
            List<Record> tape = new List<Record>();

            // Входни данни: Input.txt
            using (StreamReader input = new StreamReader("Input.txt"))
            {
                var line = input.ReadLine();
                System.Console.WriteLine(line);

                while (line != "END")
                {
                    // 0 = Id, 1 = Lenght, 2 = Probability
                    var array = line.Split().ToArray();

                    tape.Add(new Record
                    {
                        Id = int.Parse(array[0]),
                        Lenght = int.Parse(array[1]),
                        Probability = float.Parse(array[2])
                    });

                    line = input.ReadLine();
                    System.Console.WriteLine(line);
                }
            }

            // Решение
            var result = tape.OrderByDescending(x => x.Probability / x.Lenght);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}