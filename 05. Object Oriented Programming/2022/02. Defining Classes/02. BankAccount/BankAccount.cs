namespace _02._BankAccount
{
	/// <summary>
	/// Банкова сметка
	/// </summary>
    public class BankAccount
    {
		private int id;

		/// <summary>
		/// Уникален идентификатор на сметкатса
		/// </summary>
		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private double balance;


		/// <summary>
		/// Баланс по сметката
		/// </summary>
		public double Balance
		{
			get { return balance; }
			set { balance = value; }
		}

	}
}
