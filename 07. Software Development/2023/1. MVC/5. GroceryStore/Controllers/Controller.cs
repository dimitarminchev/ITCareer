using _5._GroceryStore.Models;
using _5._GroceryStore.Views;

namespace _5._GroceryStore.Controllers
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
                view.priceOfVegetables, 
                view.priceOfFruit, 
                view.kilosVegetables, 
                view.kilosFruits
            );

            view.Total = model.CalculateTotal();

            view.ShowTotal();
        }

    }
}
