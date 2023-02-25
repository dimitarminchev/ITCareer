using _10._Repair.Models;
using _10._Repair.Views;

namespace _10._Repair.Controllers
{
    public class Controller
    {
        public View view { get; set; }

        public Model model { get; set; }

        public Controller()
        {
            view = new View();
            while (model is null)
            {
                try
                {
                    model = new Model(view.N, view.W, view.L, view.M, view.O);
                }
                catch (Exception e)
                {
                    view.Response = e.Message;
                    view.ShowResponse();
                }
            }
            view.Response = model.CalculateResponse();
            view.ShowResponse();
        }
    }
}
