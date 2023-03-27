using System.Reflection;

namespace BonApetit
{
    internal class Program
    {
        private static Dictionary<string, Product> products = new Dictionary<string, Product>();
        private static Dictionary<string, Meal> meals = new Dictionary<string, Meal>();

        private static void AddProduct(string name, double price, int weight)
        {
            try
            {
                products.Add(name, new Product(name, price, weight));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void AddMultiProduct(int productsCount)
        {
            for (int i = 0; i < productsCount; i++)
            {
                string[] productData = Console.ReadLine().Split(' ').ToArray();
                try
                {
                    products.Add(productData[0], new Product(productData[0], double.Parse(productData[1]), int.Parse(productData[2])));

                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void AddMeal(string name, string type)
        {
            try
            {
                meals.Add(name, new Meal(name, type));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void AddMealProducts(string name, string type, int productsCount)
        {
            List<Product> mealProducts = new List<Product>();
            string[] productData = Console.ReadLine().Split(' ').ToArray();
            foreach (var product in productData)
            {
                mealProducts.Add(products[product]);
            }

            try
            {
                meals.Add(name, new Meal(name, type, mealProducts));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void AddProductToMeal(string productName, string mealName)
        {
            if (meals[mealName].GetType().GetMethod("AddProduct") != null)
            {
                MethodInfo method = meals[mealName].GetType().GetMethod("AddProduct");
                method.Invoke(meals[mealName], new[] { products[productName] });
            }
        }

        private static void ContainsProduct(string productName, string mealName)
        {
            if (meals[mealName].GetType().GetMethod("ContainsProduct") != null)
            {
                MethodInfo method = meals[mealName].GetType().GetMethod("ContainsProduct");
                bool result = (bool)method.Invoke(meals[mealName], new[] { productName });

                if (result)
                {
                    Console.WriteLine($"{productName} is contained in {mealName}.");
                }
                else
                {
                    Console.WriteLine($"{productName} is NOT contained in {mealName}.");
                }
            }

        }

        private static void GetMealPrice(string mealName)
        {
            if (meals[mealName].GetType().GetProperty("Price") != null)
            {
                var magic = Math.Round((double)meals[mealName].GetType().GetProperty("Price").GetValue(meals[mealName]), 2);
                Console.WriteLine($"The price of {mealName} is: {magic:0.00}");
            }
        }

        private static void PrintMealRecipe(string mealName)
        {
            if (meals[mealName].GetType().GetMethod("PrintRecipe") != null)
            {
                MethodInfo method = meals[mealName].GetType().GetMethod("PrintRecipe");
                method.Invoke(meals[mealName], null);
            }
        }

        private static void OrderMeal(string mealName)
        {
            if (meals[mealName].GetType().GetMethod("Order") != null)
            {
                MethodInfo method = meals[mealName].GetType().GetMethod("Order");
                method.Invoke(meals[mealName], null);
            }

        }

        private static void GetSpecialty()
        {

            MethodInfo method = typeof(Meal).GetMethod("GetSpecialty");
            Meal specialty = (Meal)method.Invoke(null, new[] { meals });

            Console.WriteLine($"The current specialty is: {specialty.Name}");
        }

        private static void RecommendByPrice(double price)
        {
            MethodInfo method = typeof(Meal).GetMethod("RecommendByPrice");
            Meal recommendation = (Meal)method.Invoke(null, new object[] { price, meals });

            var magic = Math.Round(recommendation.Price, 2);
            Console.WriteLine($"The recommended meal for {price} is {recommendation.Name}. It costs {magic:0.00}");
        }
        private static void RecommendByPriceAndType(double price, string type)
        {
            MethodInfo method = typeof(Meal).GetMethod("RecommendByPriceAndType");
            Meal recommendation = (Meal)method.Invoke(null, new object[] { price, type, meals });

            var magic = Math.Round(recommendation.Price, 2);
            Console.WriteLine($"The recommended meal for {price} of type {type} is {recommendation.Name}. It costs {magic:0.00}");
        }

        private static void GetCheapestProduct()
        {
            MethodInfo method = typeof(Product).GetMethod("GetCheapestProduct");
            Product cheapest = (Product)method.Invoke(null, new object[] { products });

            Console.WriteLine($"The cheapest product is {cheapest.Name}.");
        }

        public static void Main(string[] args)
        {

            string command = "";
            do
            {
                command = Console.ReadLine();
                string[] commandData = command.Split(' ').ToArray();

                switch (commandData[0])
                {
                    case "AddProduct":
                        AddProduct(commandData[1], double.Parse(commandData[2]), int.Parse(commandData[3]));
                        break;
                    case "AddMultiProducts":
                        AddMultiProduct(int.Parse(commandData[1]));
                        break;
                    case "AddMeal":
                        AddMeal(commandData[1], commandData[2]);
                        break;
                    case "AddMealProducts":
                        AddMealProducts(commandData[1], commandData[2], int.Parse(commandData[3]));
                        break;
                    case "AddProductToMeal":
                        AddProductToMeal(commandData[1], commandData[2]); 
                        break;
                    case "ContainsProduct":
                        ContainsProduct(commandData[1], commandData[2]); 
                        break;
                    case "GetMealPrice":
                        GetMealPrice(commandData[1]);
                        break;
                    case "PrintMealRecipe":
                        PrintMealRecipe(commandData[1]);
                        break;
                    case "OrderMeal":
                        OrderMeal(commandData[1]);
                        break;
                    case "GetSpecialty":
                        GetSpecialty();
                        break;
                    case "RecommendByPrice":
                        RecommendByPrice(double.Parse(commandData[1]));
                        break;
                    case "RecommendByPriceAndType":
                        RecommendByPriceAndType(double.Parse(commandData[1]), commandData[2]);
                        break;
                    case "Cheapest":
                        GetCheapestProduct();
                        break;
                    case "PrintProduct":
                        Console.WriteLine(products[commandData[1]].ToString());
                        break;
                    case "PrintMeal":
                        Console.WriteLine(meals[commandData[1]].ToString());
                        break;
                }


            } while (command != "End");
        }
    }
}