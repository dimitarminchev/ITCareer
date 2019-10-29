using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Create":
                        accounts.Add(new BankAccount { ID = int.Parse(command[1]), Balance = double.Parse(command[2]) });
                        break;
                    case "Deposit":
                        Bank.DepositFunds(int.Parse(command[1]), accounts, double.Parse(command[2]));
                        break;
                    case "Withdraw":
                        Bank.WithdrawFunds(int.Parse(command[1]), accounts, double.Parse(command[2]));
                        break;
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            foreach (var account in accounts.OrderByDescending(x => x.Balance))
            {
                Console.WriteLine(account.ToString());
            }
        }
    }
}
