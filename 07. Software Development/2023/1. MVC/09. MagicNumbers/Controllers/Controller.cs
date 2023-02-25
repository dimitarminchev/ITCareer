using _9._MagicNumbers.Models;
using _9._MagicNumbers.Views;
namespace _9._MagicNumbers.Controllers
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
