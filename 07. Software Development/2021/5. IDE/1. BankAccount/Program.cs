using System;

/// <summary>
/// Bank Account Namespace
/// </summary>
namespace _1._BankAccount
{
    /// <summary>
    /// Bank Accound main program class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Bank Accound main program method.
        /// </summary>
        /// <param name="args">Arguments from the command prompt.</param>
        static void Main(string[] args)
        {
            BankAccount bankAccound = new BankAccount(1, 100);
            Console.WriteLine("Bank accound #{0} balance {1}$", bankAccound.Id, bankAccound.Balance);
        }
    }
}
