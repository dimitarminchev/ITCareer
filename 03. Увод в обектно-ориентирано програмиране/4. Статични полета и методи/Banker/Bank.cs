namespace Banker
{
    class Bank
    {
        private static List<BankAccount> accounts;

        static Bank()
        {
            accounts = new List<BankAccount>();
        }

        public static void Deposit(int id, double amount)
        {
            var account = accounts.Where(item => item.Id == id).FirstOrDefault();
            if (account == null)
            {
                accounts.Add(new BankAccount(id, amount));
            }
            else
            {
                accounts.Where(item => item.Id == id).First().Deposit(amount);
            }
        }

        public static void Withdraw(int id, double amount)
        {
            var account = accounts.Where(item => item.Id == id).FirstOrDefault();
            if (account == null)
            {
                throw new ArgumentException("Bank account does not exists.");
            }
            else
            {
                accounts.Where(item => item.Id == id).First().Withdraw(amount);
            }
        }

        public static void Print()
        {
            accounts.ForEach(account => Console.WriteLine(account));
        }
    }
}
