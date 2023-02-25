using _8._Div.Models;
using _8._Div.Views;
namespace _8._Div.Controllers
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
