using _7._Trip.Models;
using _7._Trip.Views;

namespace _7._Trip.Controllers
{
    public class Controller
    {
        public Model model { get; set; }

        public View view { get; set; }

        public Controller()
        {
            view = new View();

            model = new Model   
            (
                view.budget,
                view.season
            );

            view.place = model.DefinePlace();
            view.expenses = model.CalculateExpenses();
            view.facility = model.Facility;

            view.ShowResult();
        }
    }
}
