namespace _2._OnTimeForExam.Controllers
{
    using _2._OnTimeForExam.Display;
    using _2._OnTimeForExam.Model;

    internal class Controller
    {
        private Display display;
        private Model model;

        public Controller()
        {
            display = new Display();
            while (model is null)
            {
                try
                {
                    display.Input();
                    model = new Model
                    (
                        display.StartHour,
                        display.StartMinutes,
                        display.ArrivalHour,
                        display.ArrivalMinutes
                    );
                }
                catch (Exception e)
                {
                    display.Response = e.Message;
                    display.ShowResponse();
                }
            }
            display.Response = model.Calculate();
            display.ShowResponse();
        }
    }
}
