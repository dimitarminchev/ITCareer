using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Гошо", 18);
            person.Accounts.Add(new BankAccount() { ID = 23, Balance = 10 } );
            person.Accounts.Add(new BankAccount() { ID = 42, Balance = 25 });
            person.Accounts.Add(new BankAccount() { ID = 32, Balance = 17 });
            person.Introduce();
            Console.WriteLine("Обща сума по банкови сметки = {0}", person.GetBalance());
        }
    }
}
