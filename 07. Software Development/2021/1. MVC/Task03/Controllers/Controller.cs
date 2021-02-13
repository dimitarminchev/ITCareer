using Task03.Model;
using Task03.Views;

namespace Task03.Controllers
{
    public class Controller
    {
        private Display display;
        private NumbersCalculate numCal;

        public Controller()
        {
            display = new Display();
            numCal = new NumbersCalculate(display.count, display.numbers);
            display.percents = numCal.FindPercentages();
            display.ShowResults();
        }
    }
}
