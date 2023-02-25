using _1._Transport.Views;
using _1._Transport.Models;

namespace _1._Transport.Controllers
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
