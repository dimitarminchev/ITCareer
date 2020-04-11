using Task_07.View;
using Task_07.Models;

namespace Task_07.Controllers
{
    public class Controller
    {
        private Display display;
        private Model model;

        public Controller()
        {
            display = new Display();
            model = new Model(display.budget, display.season);
            display.place = model.DefinePlace();
            display.expenses = model.CalculateExpenses();
            display.facility = model.Facility;
            display.ShowResult();
        }
    }
}
