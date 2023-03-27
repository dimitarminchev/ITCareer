namespace Banker
{
    class Program
    {
        static void Main(string[] args)
        {
            var cmd = Console.ReadLine().Split().ToArray();
            while (cmd[0] != "Close")
            {
                try
                {
                    switch (cmd[0])
                    {
                        case "Deposit":
                            Bank.Deposit(int.Parse(cmd[1]), double.Parse(cmd[2]));
                            break;
                        case "Withdraw":
                            Bank.Withdraw(int.Parse(cmd[1]), double.Parse(cmd[2]));
                            break;
                        case "Print":
                            Bank.Print();
                            break;
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                cmd = Console.ReadLine().Split().ToArray();
            }
        }
    }
}