/// <summary>
/// Task "BankAccount" namespace.
/// </summary>
namespace BankAccount
{
    /// <summary>
    /// Task "BankAccount" main prorgam class.
    /// </summary>
    public class Program 
    {
        /// <summary>
        /// Task "BankAccount" main prorgam method.
        /// </summary>
        /// <param name="args">no arguments needed</param>
        public static void Main(string[] args)
        {
            // Arguments check
            if (args.Count() != 2)
            {
                Console.WriteLine("Syntax: BankAccount.exe [Id] [Balance]");
                return;
            }

            // Parse Arguments
            int id = int.Parse(args[0]);
            decimal balance = decimal.Parse(args[1]);

            // Create account ant print balance
            BankAccount account = new BankAccount(id, balance);
            Console.WriteLine(account);
        }
    }
}