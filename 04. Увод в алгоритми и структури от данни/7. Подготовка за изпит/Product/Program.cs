namespace Product
{
    public class Program
    {
        static Fridge fridge = new Fridge();

        static void Main(string[] args)
        {
            string line;

            while ("END" != (line = System.Console.ReadLine()))
            {
                string[] cmdArgs = line.Split(' ');

                switch (cmdArgs[0])
                {
                    case "Add":
                        AddProduct(cmdArgs[1]);
                        break;
                    case "Check":
                        CheckProductIsInStock(cmdArgs[1]);
                        break;
                    case "Remove":
                        try
                        {
                            int index = int.Parse(cmdArgs[1]);
                            RemoveProductByIndex(index);
                        }
                        catch (FormatException e)
                        {
                            RemoveProductByName(cmdArgs[1]);
                        }
                        break;
                    case "Print":
                        ProvideInformationAboutAllProducts();
                        break;
                    case "Cook":
                        CookMeal(cmdArgs.Skip(1).ToArray());
                        break;
                }
            }
        }

        private static void CookMeal(string[] indexes)
        {
            string[] products = fridge.CookMeal(int.Parse(indexes[0]), int.Parse(indexes[1]));
            Console.WriteLine("Meal cooked. Used Products: " + string.Join(", ", products));
        }

        private static void ProvideInformationAboutAllProducts()
        {
            string[] info = fridge.ProvideInformationAboutAllProducts();
            foreach (var item in info)
            {
                Console.WriteLine($"Product {item.ToString()}");
            }
        }

        private static void RemoveProductByName(string name)
        {
            string ProductName = fridge.RemoveProductByName(name);
            if (ProductName != null)
            {
                Console.WriteLine("Removed: " + ProductName);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        private static void RemoveProductByIndex(int index)
        {
            string ProductName = fridge.RemoveProductByIndex(index);
            if (ProductName != null)
            {
                Console.WriteLine("Removed: " + ProductName);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        private static void CheckProductIsInStock(string name)
        {
            bool isInStock = fridge.CheckProductIsInStock(name);

            Console.WriteLine(isInStock ? $"Product {name} is in stock."
                : "Not in stock");
        }

        private static void AddProduct(string name)
        {
            fridge.AddProduct(name);
        }
    }
}