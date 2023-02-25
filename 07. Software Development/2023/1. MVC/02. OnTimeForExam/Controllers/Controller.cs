using _2._OnTimeForExam.Models;
using _2._OnTimeForExam.Views;

namespace _2._OnTimeForExam.Controllers
{
    public class Controller
    {
        private View view;
        private Model model;

        public Controller()
        {
            view = new View();
            while (model is null)
            {
                try
                {
                    model = new Model
                    (
                        view.StartHour,
                        view.StartMinutes,
                        view.ArrivalHour,
                        view.ArrivalMinutes
                    );
                }
                catch (Exception e)
                {
                    view.Response = e.Message;
                    view.ShowResponse();
                }
            }
            view.Response = model.Calculate();
            view.ShowResponse();
        }
    }
}
