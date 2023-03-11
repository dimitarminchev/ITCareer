using Newtonsoft.Json;

/// <summary>
/// Task "Products" namespace.
/// </summary>
namespace Products
{
    /// <summary>
    /// Task "Products" main program class.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Task "Products" main program method.
        /// </summary>
        static void Main(string[] args)
        {
            // Step 1. Serialize Object to JSON
            Product product = new Product(1,"Coca Cola", 2.4m, 100, new DateTime(2023,09,10));
            string json = JsonConvert.SerializeObject(product);

            Console.WriteLine("Step 1. Serialize Object to JSON");
            Console.WriteLine(json);
            Console.WriteLine(Environment.NewLine);

            // Step 2. Deserialize JSON to Object
            Product second = JsonConvert.DeserializeObject<Product>(json);

            Console.WriteLine("Step 2. Deserialize JSON to Object");
            Console.WriteLine(second);
            Console.WriteLine(Environment.NewLine);
        }
    }
}