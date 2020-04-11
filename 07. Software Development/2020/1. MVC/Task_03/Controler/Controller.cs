using Task_03.Models;
using Task_03.View;

namespace Task_03.Controler
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
