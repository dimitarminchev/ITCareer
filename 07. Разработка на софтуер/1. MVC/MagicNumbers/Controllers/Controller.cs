using MagicNumbers.Models;
using MagicNumbers.Views;

namespace MagicNumbers.Controllers
{
    public class Controller
    {
        public View view { get; set; }

        public Model model { get; set; }

        public Controller()
        {
            view = new View();

            model = new Model( view.magicNumber );

            view.magicNumbers = model.GenerateCombinations();

            view.ShowResults();
        }
    }
}
