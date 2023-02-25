using _3._Histogram.Models;
using _3._Histogram.Views;

namespace _3._Histogram.Controllers
{
    public class Controller
    {
        private View view;
        private Model model;

        public Controller()
        {
            view = new View();
            model = new Model(view.count, view.numbers);

            view.percents = model.FindPercentages();

            view.ShowPercents();
        }
    }
}
