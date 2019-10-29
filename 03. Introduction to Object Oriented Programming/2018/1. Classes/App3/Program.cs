using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Program
    {
        // Главен метод
        static void Main(string[] args)
        {
            // Иван Иванов
            Person Ivan = new Person();
            Ivan.Name = "Ivan Ivanov";
            Ivan.Age = 32;
            Ivan.Accounts.Add
            (
                new BankAccount()
                {
                    ID = 123,
                    Balance = 123.45
                }
            );

            // Петър Петров
            Person Peter = new Person();
            Peter.Name = "Peter Petrov";
            Peter.Age = 45;
            Peter.Accounts = new List<BankAccount>()
            {
                new BankAccount()
                {
                    ID = 321,
                    Balance = 543.21
                },
                new BankAccount()
                {
                    ID = 413,
                    Balance = 1322.32
                }
            };

            // Извеждане на информацията
            Console.WriteLine("Person: {0}, Total Balance = {1}", Ivan.Name, Ivan.GetBalance());
            Console.WriteLine("Person: {0}, Total Balance = {1}", Peter.Name, Peter.GetBalance());
        }
    }
}
