namespace BankAccountClient
{
    class Client
    {
        Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        public void Create(int id)
        {
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var account = new BankAccount();
                account.Id = id;
                accounts.Add(id, account);
            }
        }

        public void Deposit(int id, double balance)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                var account = accounts.First(x => x.Key == id).Value;
                account.Deposit(balance);
            }
        }

        public void Withdraw(int id, double balance)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                var account = accounts.First(x => x.Key == id).Value;
                if (account.Balance < balance)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    account.Withdraw(balance);
                }
            }
        }

        public void Print(int id)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                var account = accounts.First(x => x.Key == id).Value;
                Console.WriteLine(account.ToString());
            }
        }
    }
}
