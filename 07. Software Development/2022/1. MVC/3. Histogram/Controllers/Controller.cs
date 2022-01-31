namespace _3._Histogram.Controllers
{
    using _3._Histogram.Model;
    using _3._Histogram.Display;

    internal class Controller
    {
        private Display display;
        private Model model;

        public Controller()
        {
            display = new Display();
            model = new Model(display.count, display.numbers);

            display.percents = model.FindPercentages();

            display.ShowResults();
        }
    }
}
