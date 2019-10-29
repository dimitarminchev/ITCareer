using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMoneyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person peter = new Person();

            peter.Name = "Peter";
            peter.Age = 23;
            peter.Accounts.Add(new BankAccount() { Iban = "BG123FIB123", Balance = 151M });
            peter.Accounts.Add(new BankAccount() { Iban = "BG342ALL123", Balance = 42M });
            peter.Accounts.Add(new BankAccount() { Iban = "BG876UBB836", Balance = 7M });

            Console.WriteLine("Balance = {0}", peter.GetBalance());
        }
    }
}
