using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        // Главен метод
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount()
            {
                Id = 12,
                Balance = 123.45
            };
            acc.Deposit(23);
            acc.Withdraw(100);
            Console.WriteLine(acc.ToString());
        }
    }
}
