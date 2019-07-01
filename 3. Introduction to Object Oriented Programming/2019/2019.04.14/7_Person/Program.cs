using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _7_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            // Списък с банкови сметки на човека
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount(1, 25.23));
            accounts.Add(new BankAccount(2, 125.14));
            accounts.Add(new BankAccount(3, 4.01));

            // Човек
            Person Ivan = new Person("Ivan", 23, accounts);

            // Да намерим общия баланс по банковите му сметки
            Console.WriteLine("Total Bank Account Balance = {0}", Ivan.GetBalance());

        }
    }
}
