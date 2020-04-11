using Task_05.View;
using Task_05.Models;

namespace Task_05.Controllers
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
