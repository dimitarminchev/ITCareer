using System;

namespace Demo
{
	/// <summary>
	/// Банкова сметка
	/// </summary>
	public class BankAccount
	{

		private int id;

		/// <summary>
		/// Уникален идентификатор на банковата сметка
		/// </summary>
		public int Id
		{
			get { return id; }
			set
			{
				if (value < 0)
				{
					throw new Exception("Value must be positive.");
				}
				id = value;
			}
		}

		private double balance;

		/// <summary>
		/// Баланс по банковата сметка
		/// </summary>
		public double Balance
		{
			get { return balance; }
			set
			{
				if (value < 0)
				{
					throw new Exception("Value must be positive.");
				}
				balance = value;
			}
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="id">Уникален идентификатор</param>
		/// <param name="balance">Баланс по сметка</param>
		public BankAccount(int id, double balance)
		{
			this.Id = id;
			this.Balance = balance;
		}

		/// <summary>
		/// Пренаписване на метод
		/// </summary>
		/// <returns>Информация за банковия акаун</returns>
		public override string ToString()
		{
			return String.Format("Id: {0}, Balance: {1}", this.Id, this.Balance);
		}
	}
}
