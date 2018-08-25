using System;

namespace OOPBasics_Burgasko
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var parts = command.Split(' ');
                var action = parts[0];
                var id = int.Parse(parts[1]);

                double amount = 0;
                if (parts.Length > 2)
                {
                    amount = double.Parse(parts[2]);
                }

                try
                {
                    switch (action)
                    {
                        case "Create":
                            AccountManager.Create(id);
                            break;
                        case "Deposit":
                            AccountManager.Deposit(id, amount);
                            break;
                        case "Withdraw":
                            AccountManager.Withdraw(id, amount);
                            break;
                        case "Print":
                            var accountInformation = AccountManager.GetAccountInformation(id);
                            Console.WriteLine(accountInformation);
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}