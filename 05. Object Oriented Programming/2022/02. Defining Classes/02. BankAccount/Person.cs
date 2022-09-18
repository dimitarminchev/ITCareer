namespace _02._BankAccount
{
	/// <summary>
	/// Човек
	/// </summary>
    public class Person
    {
		private string name;

		/// <summary>
		/// Име на човека
		/// </summary>
		public string Name
		{
			get { return name; }
			set 
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Name can not be empty!");
				}
				name = value; 
			}
		}

		private int age;

		/// <summary>
		/// Възраст на човека
		/// </summary>
		public int Age
		{
			get { return age; }
			set 
			{
				if (value <= 0)
				{
					throw new ArgumentException("Age must be positive value!");
				}
				age = value; 
			}
		}

        private List<BankAccount> accounts = new List<BankAccount>();

		/// <summary>
		/// Банкови сметки
		/// </summary>
		public List<BankAccount> Accounts
		{
			get { return accounts; }
			set { accounts = value; }
		}

		/// <summary>
		/// Обща стойност на сумита по всички банкови сметки на човека
		/// </summary>
		/// <returns></returns>
        public double GetBalance()
        {
            return accounts.Sum(element => element.Balance);
        }

		/// <summary>
		/// Представяне на човека
		/// </summary>
        public void IntroduceYourself()
		{
			Console.WriteLine("Hello! My name is {0} and I am {1} years old.", name, age);
		}
	}
}
