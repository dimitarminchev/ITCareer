using Task_09.View;
using Task_09.Models;

namespace Task_09.Controllers
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
