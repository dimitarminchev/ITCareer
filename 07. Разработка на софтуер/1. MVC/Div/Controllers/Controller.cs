using Div.Models;
using Div.Views;

namespace Div.Controllers
{
    public class Controller
    {
        public View view { get; set; }

        public Model model { get; set; }

        public Controller()
        {
            view = new View();

            model = new Model
            (
                view.numbers
            );

            view.Response = model.CalculateResponse();

            view.ShowResponse();
        }
    }
}
