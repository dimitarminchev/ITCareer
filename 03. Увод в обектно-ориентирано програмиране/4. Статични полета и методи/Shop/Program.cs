namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split().ToArray();
            while (line[0] != "Close")
            {
                try
                {
                    switch (line[0])
                    {
                        case "Add":
                            Orders.Add(line[1], line[2], double.Parse(line[3]), double.Parse(line[4]));
                            break;
                        case "Sell":
                            Orders.Sell(line[1], double.Parse(line[2]));
                            break;
                        case "Update":
                            Orders.Update(line[1], double.Parse(line[2]));
                            break;
                        case "PrintA":
                            Orders.PrintA();
                            break;
                        case "PrintU":
                            Orders.PrintU();
                            break;
                        case "PrintD":
                            Orders.PrintD();
                            break;
                        case "Calculate":
                            Console.WriteLine("{0:f2}", Orders.Calculate());
                            break;
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }

                line = Console.ReadLine().Split().ToArray();
            }
        }
    }
}