using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_01.Views;
using Task_01.Models;

namespace Task_01.Controllers
{
    class CalculatePrice
    {
        private Transport transport;
        private Display display;

        public CalculatePrice()
        {
            display = new Display();
            transport = new Transport(display.kilometers, display.time);
            display.totalPrice = transport.CalculatePrice();
            display.ShowCheapestWayToTravel();
        }
    }
}
