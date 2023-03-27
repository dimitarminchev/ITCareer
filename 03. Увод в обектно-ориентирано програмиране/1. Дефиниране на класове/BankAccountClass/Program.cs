namespace BankAccountClass
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Id = 1;
            account.Balance = 15;
            Console.WriteLine($"Account {account.Id}, balance {account.Balance}");
        }
    }
}