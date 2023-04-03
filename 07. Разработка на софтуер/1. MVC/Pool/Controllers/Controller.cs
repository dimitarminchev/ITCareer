using Pool.Models;
using Pool.Views;

namespace Pool.Controllers
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
                view.v, 
                view.p1, 
                view.p2, 
                view.h
            );

            view.Response = model.CalculateResponse();

            view.ShowResponse();
        }
    }
}
