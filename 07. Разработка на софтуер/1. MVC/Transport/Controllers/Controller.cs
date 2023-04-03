using Transport.Views;
using Transport.Models;

namespace Transport.Controllers
{
    public class Controller
    {
        private View view;
        private Model model;

        public Controller()
        {
            view = new View();
            model = new Model(view.kilometers, view.time);

            view.totalPrice = model.CalculatePrice();

            view.ShowCheapestWayToTravel();
        }
    }
}
