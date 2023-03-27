namespace WarehouseUpdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Split().ToList();
            var quantities = Console.ReadLine().Split().Select(long.Parse).ToList();
            var prices = Console.ReadLine().Split().Select(float.Parse).ToList();

            var line = Console.ReadLine();
            while (line != "done")
            {
                var command = line.Split();

                try
                {
                    var index = products.FindIndex(x => x == command[0]);
                    if (float.Parse(command[1]) > quantities[index])
                    {
                        Console.WriteLine($"We do not have enough {command[0]}");
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} x {command[1]} costs {prices[index] * long.Parse(command[1]):f2}");
                    }
                    quantities[index] -= long.Parse(command[1]);
                }
                catch
                {
                    Console.WriteLine($"We do not have enough {command[0]}");
                }

                line = Console.ReadLine();
            }
        }
    }
}