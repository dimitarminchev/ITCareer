using Histogram.Models;
using Histogram.Views;

namespace Histogram.Controllers
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
