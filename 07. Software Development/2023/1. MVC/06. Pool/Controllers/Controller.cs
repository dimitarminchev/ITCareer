using _6._Pool.Models;
using _6._Pool.Views;

namespace _6._Pool.Controllers
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
