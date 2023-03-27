namespace BankAccountClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var cmd = Console.ReadLine().Split().ToArray();

            while (cmd[0] != "End")
            {
                switch (cmd[0])
                {
                    case "Create":
                        client.Create(int.Parse(cmd[1]));
                        break;

                    case "Deposit":
                        client.Deposit(int.Parse(cmd[1]), double.Parse(cmd[2]));
                        break;

                    case "Withdraw":
                        client.Withdraw(int.Parse(cmd[1]), double.Parse(cmd[2]));
                        break;

                    case "Print":
                        client.Print(int.Parse(cmd[1]));
                        break;
                }
                cmd = Console.ReadLine().Split().ToArray();
            }
        }
    }
}