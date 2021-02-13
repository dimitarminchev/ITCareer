using Task09.Models;
using Task09.Views;

namespace Task09.Controllers
{
    public class Controller
    {
        public Display display;
        public Model model;

        public Controller()
        {
            display = new Display();
            model = new Model(display.magicNumber);
            display.magicNumbers = model.generateCombinations();
            display.ShowResults();
        }
    }
}
