using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Създаваме обект инстанция на класа
            BankAccount account = new BankAccount();

            // Задаваме номер на банкова сметка, внасяме 15 и теглим 5
            account.ID = 1;
            account.Deposit(15);
            account.Withdraw(5);

            // Отпечатваме информация за баланса по банковата сметка
            Console.WriteLine(account.ToString());
        }
    }
}
