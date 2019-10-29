using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Model;
using Trip.View;

namespace Trip.Controller
{
    class TripActionControler
    {
        Display display;
        TripM trip;

        public TripActionControler()
        {
            this.display = new Display();
            this.trip = new TripM(display.Budget, display.Seazon);
            display.Country = trip.GetCountry();
            display.Place = trip.GetSleep();
            display.Price = trip.GetProcent();
            display.PrintValues();
        }
    }
}
