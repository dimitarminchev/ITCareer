namespace _5._GroceryStore.Controllers
{
    using _5._GroceryStore.View;
    using _5._GroceryStore.Model;

    internal class Controller
    {
        private View view;
        private Model model;

        public Controller()
        {
            view = new View();
            model = new Model(view.priceOfVegetables, view.priceOfFruit, view.kilosVegetables, view.kilosFruits);
            view.total = model.Calculate();
            view.ShowResult();
        }
    }
}
