using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Iban = "BG1234FIB567432112";
            account.Deposit(15M);
            account.Withdraw(5M);

            Console.WriteLine(account.ToString());
        }
    }
}
