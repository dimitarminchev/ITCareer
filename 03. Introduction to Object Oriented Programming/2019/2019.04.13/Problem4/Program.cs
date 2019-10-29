using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int, BankAccount>();

            // Input
            var line = Console.ReadLine().Split().ToArray();
            while (line[0] != "End")
            {
                switch (line[0])
                {
                    // Create
                    case "Create":
                        if (accounts.ContainsKey(int.Parse(line[1])))
                        {
                            Console.WriteLine("Account already exists");
                        }
                        else
                        {
                            int id = int.Parse(line[1]);
                            accounts[id] = new BankAccount() { Id = id };
                        }
                        break;
                        // Deposit
                    case "Deposit":
                        if (!accounts.ContainsKey(int.Parse(line[1])))
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        else
                        {
                            accounts[int.Parse(line[1])].Deposit(double.Parse(line[2]));
                        }
                        break;
                    // Withdraw
                    case "Withdraw":
                        if (!accounts.ContainsKey(int.Parse(line[1])))
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        else
                        {
                            accounts[int.Parse(line[1])].Withdraw(double.Parse(line[2]));
                        }
                        break;
                    // Print
                    case "Print":
                        if (!accounts.ContainsKey(int.Parse(line[1])))
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        else
                        {
                            accounts[int.Parse(line[1])].Print();
                        }
                        break;
                }
                line = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
