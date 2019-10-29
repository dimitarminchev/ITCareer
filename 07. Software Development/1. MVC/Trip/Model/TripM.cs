using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip.Model
{
    class TripM
    {
        public double budget { get; set; }
        public string seazon { get; set; }

        public TripM(double budget, string seazon)
        {
            this.budget = budget;
            this.seazon = seazon;
        }

        public string GetCountry()
        {
            if (this.budget <= 100)
            {
                return "Bulgaria";
            }
            else if (this.budget <= 1000)
            {
                return "Balkans";
            }
            else
                return "Europe";
        }
        public string GetSleep()
        {
            if (this.seazon == "summer")
            {
                return "Camp";
            }
            else
                return "Hotel";
        }
        public double GetProcent()
        {
            if (this.seazon == "summer" && GetCountry() == "Bulgaria")
            {
                return (this.budget * 0.30);
            }
            else if (this.seazon == "winter" && GetCountry() == "Bulgaria")
            {
                return (this.budget * 0.70);
            }

            if (this.seazon == "summer" && GetCountry() == "Balkans")
            {
                return (this.budget * 0.40);
            }
            else if (this.seazon == "winter" && GetCountry() == "Balkans")
            {
                return (this.budget * 0.80);
            }

            else
            {
                return (this.budget * 0.90);
            }
        }
    }
}
