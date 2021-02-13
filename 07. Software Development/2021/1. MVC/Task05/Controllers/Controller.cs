using Task05.Models;
using Task05.Views;

namespace Task05.Controllers
{
    public class Controller
    {
        private Display display;
        private Model model;

        public Controller()
        {
            display = new Display();
            model = new Model(display.priceOfVegetables, display.priceOfFruit, display.kilosVegetables, display.kilosFruits);
            display.total = model.Calculate();
            display.ShowResult();
        }
    }
}
