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
            var person = new Person();
            person.Name = "Ivan";
            person.Age = 32;
            person.Accounts = new List<BankAccount>()
            {
                new BankAccount() {  Id = 1, Balance = 1000 },
                new BankAccount() { Id = 2, Balance = 2000 },
                new BankAccount() { Id = 3, Balance = 3000 }
            };
            Console.WriteLine("Balance = {0}", person.GetBalance());
        }
    }
}
