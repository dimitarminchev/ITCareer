using System;

namespace BankAccount
{
    /// <summary>
    /// Програма
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Главен метод на програмата
        /// </summary>
        /// <param name="args">Аргументи</param>
        static void Main(string[] args)
        {
            // Обект инстанция на класа
            BankAccount account = new BankAccount(42, 123.45);

            // Отпечатване на информация за банковата сметка
            Console.WriteLine(account.ToString());
        }
    }
}
