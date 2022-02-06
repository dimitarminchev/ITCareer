using System;

/// <summary>
/// Integrated Development Environment: "Person" Namespace
/// </summary>
namespace Person
{
    /// <summary>
    /// Integrated Development Environment: "Person" Main Program Class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Integrated Development Environment: "Person" Main Method
        /// </summary>
        public static void Main(string[] args)
        {
            // Create new person "Ivan", 23, with 3 bank accounts 
            Person ivan = new Person
            (
                // Person name
                "Ivan Ivanov",

                // Person age
                23,

                // Person bank accounts
                new List<BankAccount> 
                {
                    new BankAccount(1, 500),
                    new BankAccount(2, 1000),
                    new BankAccount(3, 250)
                }
            );

            // Check if "GetBalance" method works
            Console.WriteLine("Total balance = {0:C}", ivan.GetBalance());

            // Error check
            try
            {
                Person peter = new Person
                (
                    "Peter Petrov",
                    -12, // Must throws exception!
                    null
                );
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }
    }
}