/// <summary>
/// Task "Person" namespace.
/// </summary>
namespace Person
{
    /// <summary>
    /// Task "Person" main prorgam class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Task "Person" main prorgam method.
        /// </summary>
        /// <param name="args">no arguments needed</param>
        public static void Main(string[] args)
        {
            // Create Bank Accounts
            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(new BankAccount(1, 100));
            bankAccounts.Add(new BankAccount(2, 200));
            bankAccounts.Add(new BankAccount(3, 300));

            // Create Person
            Person person = new Person("Ivan Ivanov", 22, bankAccounts);

            // Print
            Console.WriteLine(person);
        }
    }
}