namespace _7._Trip.Controllers
{
    using _7._Trip.Model;
    using _7._Trip.View;

    internal class Controller
    {
        private Model model;
        private View view;

        public Controller()
        {
            view = new View();
            model = new Model(view.budget, view.season);
            view.place = model.DefinePlace();
            view.expenses = model.CalculateExpenses();
            view.facility = model.Facility;
            view.ShowResult();
        }
    }
}
