namespace _1._Transport.Controllers
{
    using _1._Transport.Model;
    using _1._Transport.Display;

    internal class Controller
    {
        private Display display;
        private Model model;

        public Controller()
        {
            display = new Display();
            model = new Model(display.kilometers, display.time);
            display.totalPrice = model.CalculatePrice();
            display.ShowCheapestWayToTravel();
        }
    }
}
