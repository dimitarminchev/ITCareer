namespace ManAndHisMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Peter = new Person();
            Peter.Name = "Peter Petrov";
            Peter.Age = 45;

            Peter.Accounts = new List<BankAccount>()
            {
                new BankAccount()
                {
                    Id = 321,
                    Balance = 543.21
                },
                new BankAccount()
                {
                    Id = 413,
                    Balance = 1322.32
                }
            };

            Console.WriteLine("Person: {0}, Total Balance = {1}", Peter.Name, Peter.GetBalance());
        }
    }
}