using GroceryStore.Models;
using GroceryStore.Views;

namespace GroceryStore.Controllers
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
