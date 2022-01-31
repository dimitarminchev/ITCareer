namespace _9._MagicNumbers.Controllers
{
    using _9._MagicNumbers.Model;
    using _9._MagicNumbers.View;

    internal class Controller
    {
        private View view;
        private Model model;

        public Controller()
        {
            view = new View();
            model = new Model(view.magicNumber);
            view.magicNumbers = model.generateCombinations();
            view.ShowResults();
        } 
    }
}
