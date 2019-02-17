using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount(1,2);
            Console.WriteLine("id = {0}, money = {1}", bankAccount.ID, bankAccount.Balance);
        }
    }
}
