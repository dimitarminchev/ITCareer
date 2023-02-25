using _4._PasswordGenerator.Models;
using _4._PasswordGenerator.Views;

namespace _4._PasswordGenerator.Controllers
{
    public class Controller
    {
        public View view = null;
        public Model model = null;

        public Controller()
        {
            view = new View();

            view.Input();

            model = new Model(view.n, view.l);

            view.Response = model.CalculatePasswords();

            view.ShowResponse();
        }
    }
}
