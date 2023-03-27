namespace BankAccountMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Deposit(15);
            account.Withdraw(5);
            Console.WriteLine(account.ToString());
        }
    }
}