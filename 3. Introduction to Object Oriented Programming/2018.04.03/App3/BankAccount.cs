using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    /// <summary>
    /// Банкова сметка
    /// </summary>
    class BankAccount
    {
        // Иденфикатор
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        // Баланс
        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }

}
