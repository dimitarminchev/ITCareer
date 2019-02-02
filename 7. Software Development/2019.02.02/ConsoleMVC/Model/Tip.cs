using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Model
{
    class Tip
    {
        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private double percent;

        public double Percent
        {
            get { return percent; }
            set
            {
                if (value > 1)
                {
                    percent = value / 100.0;
                }
                else percent = value;
            }
        }

        public Tip(double amount, double percent)
        {
            Amount = amount;
            Percent = percent;
        }

        public Tip() : this(0, 0) { }

        public double CalculateTip()
        {
            return Amount * Percent;
        }

        public double CalculateTotal()
        {
            return CalculateTip() + Amount;
        }

    }
}
