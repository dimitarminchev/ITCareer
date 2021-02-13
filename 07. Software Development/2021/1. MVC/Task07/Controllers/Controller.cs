using Task07.Views;
using Task07.Models;

namespace Task07.Controllers
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
