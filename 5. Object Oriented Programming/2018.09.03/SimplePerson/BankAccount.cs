using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePerson
{
    // Банкова сметка
    public class BankAccount
    {
        // Уникален идентификатор на сметка
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        // Баланс на сметката
        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }

}
