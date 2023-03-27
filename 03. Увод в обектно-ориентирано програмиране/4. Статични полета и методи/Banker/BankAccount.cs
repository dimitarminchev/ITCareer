namespace Banker
{
    class BankAccount
    {
        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                if (value < 0) throw new ArgumentException("Id must be positive value.");
                else id = value;
            }
        }

        private double balance;

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0) throw new ArgumentException("Balance must be positive value.");
                else balance = value;
            }
        }

        public BankAccount(int id, double balance)
        {
            this.Id = id;
            this.Balance = balance;
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("Insufficient balance.");
            }
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Id: {this.Id}, Balance: {this.Balance}";
        }
    }
}
