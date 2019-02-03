using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip.View
{
    class Display
    {
        private string country;
        private string place;
        private double price;

        private double budget;
        private string seazon;

        public Display()
        {
            GetValues();
        }

        public void GetValues()
        {
            this.budget = double.Parse(Console.ReadLine());
            this.seazon = Console.ReadLine();
        }

        public void PrintValues()
        {
            Console.WriteLine($"Somewhere in {this.country:f2}");
            Console.WriteLine($"{this.place} - {this.price:f2}");
        }


        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Place
        {
            get { return place; }
            set { place = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Seazon
        {
            get { return seazon; }
            private set { seazon = value; }
        }
        public double Budget
        {
            get { return budget; }
            private set { budget = value; }
        }
    }
}
