using Task01.Model;
using Task01.Views;

namespace Task01.Controllers
{
    public class CalculatePrice
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
