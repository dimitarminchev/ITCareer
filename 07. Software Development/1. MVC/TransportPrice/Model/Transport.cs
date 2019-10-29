using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice.Model
{
    class Transport
    {
        protected int kilometers;
        protected string timeOfDay;

        public int Kilometers
        {
            get { return kilometers; }
            set { kilometers = value; }
        }

        public string TimeOfDay
        {
            get { return timeOfDay; }
            set { timeOfDay = value; }
        }

        public Transport(int kilometers, string timeOfDay)
        {
            this.kilometers = kilometers;
            this.timeOfDay = timeOfDay;
        }

        public double CalculatePrice()
        {
            double price;
           
            if (this.kilometers < 20)
            {
                price = 0.7;
                if (this.timeOfDay == "day") price += kilometers * 0.79;
                else price += kilometers * 0.90;
            }

            else if (this.kilometers < 100) price = kilometers * 0.09;
            else price = kilometers * 0.06;
            return price;          
        }
    }
}
