using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportPrice.Model;
using TransportPrice.Views; 

namespace TransportPrice.Controllers
{
    class TransportPriceActionController
    {
        Transport transport;
        Display display;

        public TransportPriceActionController()
        {
            this.display = new Display();
            this.transport = new Transport(this.display.Kilometers, this.display.TimeOfDay);
            this.display.FinalPrice = this.transport.CalculatePrice();
            this.display.PrintValues();

        }
    }
}
