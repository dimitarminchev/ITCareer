namespace GroceryStore.Views
{
    public class View
    {
        public double priceOfVegetables { get; set; }

        public double priceOfFruit { get; set; }

        public int kilosVegetables { get; set; }

        public int kilosFruits { get; set; }

        public double Total { get; set; }

        public View()
        {
            priceOfVegetables = 0;
            priceOfFruit = 0;
            kilosVegetables = 0;
            kilosFruits = 0;
            Total = 0;
            Input();
        }

        public void Input()
        {
            Console.WriteLine("Enter price per kilogram of the vegetables: ");
            priceOfVegetables = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter price per kilogram of the fruits: ");
            priceOfFruit = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter how many kilos vegetables: ");
            kilosVegetables = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter how many kilos fruits: ");
            kilosFruits = int.Parse(Console.ReadLine());
        }

        public void ShowTotal()
        {
            Console.WriteLine(Total);
        }
    }
}
