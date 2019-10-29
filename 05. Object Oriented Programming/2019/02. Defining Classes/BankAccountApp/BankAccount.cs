using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class BankAccount
    {
        // Идентификатор на сметка
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // Баланс на сметка
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

    }
}
