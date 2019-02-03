using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice.Views
{
    class Display
    {
        public int Kilometers { get; set; }
        public string TimeOfDay { get; set; }
        public double FinalPrice { get; set; }

        public Display()
        {
            this.Kilometers = 0;
            this.TimeOfDay = string.Empty;
            this.FinalPrice = 0;
            GetValues();
        }

        private void GetValues()
        {
            this.Kilometers = int.Parse(Console.ReadLine());
            this.TimeOfDay = Console.ReadLine();          
        }

        public void PrintValues()
        {
            Console.WriteLine("{0:f2}", this.FinalPrice);
        }
    }
}
