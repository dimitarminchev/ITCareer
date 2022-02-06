using System;

/// <summary>
/// Integrated Development Environment: "Bank Account" Namespace
/// </summary>
namespace BankAccount
{
    /// <summary>
    /// Integrated Development Environment: "Bank Account" Main Program Class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Integrated Development Environment: "Bank Account" Main Method
        /// </summary>
        public static void Main(string[] args)
        {
            // Create sample Bank Account witho 1500 money
            BankAccount account = new BankAccount(1, 1500);
            Console.WriteLine("Id = {0}, Balance = {1}", account.Id, account.Balance);

            // Try to create bank account with negative money balance
            try
            {
                BankAccount wringAccount = new BankAccount(2, -500);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
   
        }
    }
}