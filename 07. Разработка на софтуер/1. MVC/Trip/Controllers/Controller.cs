using Trip.Models;
using Trip.Views;

namespace Trip.Controllers
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
