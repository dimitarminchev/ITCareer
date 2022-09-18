using System.ComponentModel.DataAnnotations;

namespace _02._BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Създаване на три банкови сметки
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount() { ID = 1, Balance = 1000 });
            accounts.Add(new BankAccount() { ID = 2, Balance = 2000 });
            accounts.Add(new BankAccount() { ID = 3, Balance = 3000 });

            // Създаваме обект person инстация на класа Person
            Person person = new Person();
            person.Name = "Peter";
            person.Age = 18;
            person.Accounts = accounts;

            // Извеждане на инсформация за човека
            person.IntroduceYourself();
            foreach (var account in person.Accounts)
            {
                Console.WriteLine("Id = {0}, Balance {1}", account.ID, account.Balance);
            }
            Console.WriteLine("Total Bank Account Balance = {0}", person.GetBalance());
        }
    }
}