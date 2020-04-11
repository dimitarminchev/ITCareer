using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Views
{
    class Display
    {
        public double Percent { get; set; }
        public double Amount { get; set; }
        public double Total { get; set; }
        public double TipAmount { get; set; }

        public Display()
        {
            Percent = 0;
            Amount = 0;
            Total = 0;
            TipAmount = 0;
            GetValues();
        }

        private void GetValues()
        {
            Console.WriteLine("Enter the amount of the meal:");
            Amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percent of the tip:");
            Percent = double.Parse(Console.ReadLine());
        }

        public void ShowTipAndTotal()
        {
            Console.WriteLine("Your tip is: \u20AC{0}", TipAmount);
            Console.WriteLine("The total will be \u20AC{0}", Total);
        }
    }
}
