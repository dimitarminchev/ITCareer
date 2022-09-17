namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000);
            Console.WriteLine("Bank Account Amount = {0}", account.Amount);
        }
    }
}