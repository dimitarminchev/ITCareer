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
            // Създаване на обект инстанция на класа
            BankAccount account = new BankAccount()
            {
                Id = 42, // идентификатор на сметка
                Balance = 123.45 // първоначална сума
            };

            // Внасяне на пари 
            account.Deposit(12.34);

            // Теглене на пари 
            account.Withdraw(100);

            // Отпечавтване на състоянието
            Console.WriteLine(account.ToString());
        }
    }
}
