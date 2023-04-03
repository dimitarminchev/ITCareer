using CrudWithoutOrm.Business;
using CrudWithoutOrm.Common;
using System.ComponentModel;
using System.Data;
using System.Runtime.Versioning;
/// <summary>
/// Task "CRUD without ORM" namespace.
/// </summary>
namespace CrudWithoutOrm.Presentation
{
    /// <summary>
    /// Task "CRUD without ORM" display class (UI)
    /// </summary>
    public class Display
    {
        private ProductBusiness productBusiness = new ProductBusiness();

        private const int closeOperationID = 6;

        /// <summary>
        /// Menu
        /// </summary>
        private void Menu()
        {
            // Menu Header
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string('-', 18) + "MENU" + new string('-', 18));
            Console.WriteLine(new string('-', 40));

            // Menu Content
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new entry");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Fetch entry by ID");
            Console.WriteLine("5. Delete entry by ID");
            Console.WriteLine("6. Exit");

            // Menu Footer
            Console.Write("Select from menu: ");
        }

        /// <summary>
        /// Input
        /// </summary>
        private void Input()
        {
            int operation = -1;
            do 
            { 
                Menu();
                operation = int.Parse(Console.ReadLine());
                switch (operation) 
                {
                    case 1:
                        ListAll();
                        break;

                    case 2:
                        Add();
                        break;

                    case 3:
                        Update();
                        break;

                    case 4:
                        Fetch();
                        break;

                    case 5:
                        Delete();
                        break;

                    default:
                        Console.WriteLine("Please select option from the menu 1 to 6.");
                        break;
                }
            }
            while (operation != closeOperationID);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Display()
        {
            Input();
        }

        /// <summary>
        /// ListAll
        /// </summary>
        private void ListAll()
        {
            // Header
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string('-', 16) + "PRODUCTS" + new string('-', 16));
            Console.WriteLine(new string('-', 40));

            List<Product> products = productBusiness.GetAll();

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id} {product.Name} {product.Price} {product.Stock}");
            }
        }

        /// <summary>
        /// Add
        /// </summary>
        private void Add()
        {
            Product product = new Product();

            Console.WriteLine("Name: ");
            product.Name = Console.ReadLine();

            Console.WriteLine("Price: ");
            product.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Stock: ");
            product.Stock = int.Parse(Console.ReadLine());

            productBusiness.Add(product);
        }

        /// <summary>
        /// Update
        /// </summary>
        private void Update()
        {
            Console.WriteLine("Enter ID of the entry to update: ");
            int id = int.Parse(Console.ReadLine());

            Product product = productBusiness.Get(id);

            if (product != null)
            {
                Console.WriteLine("Name: ");
                product.Name = Console.ReadLine();

                Console.WriteLine("Price: ");
                product.Price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Stock: ");
                product.Price = int.Parse(Console.ReadLine());

                productBusiness.Update(product);    
            }
            else
            {
                Console.WriteLine("Error: Product not found!");
            }
        }

        /// <summary>
        /// Fetch
        /// </summary>
        private void Fetch()
        {
            Console.WriteLine("Enter ID of the entry to fetch: ");
            int id = int.Parse(Console.ReadLine());

            Product product = productBusiness.Get(id);

            if (product != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine($"Id: {product.Id}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine($"Stock: {product.Stock}");
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("Error: Product not found!");
            }
        }

        /// <summary>
        /// Delete
        /// </summary>
        private void Delete()
        {
            Console.WriteLine("Enter ID of the entry to delete: ");
            int id = int.Parse(Console.ReadLine());
            productBusiness.Delete(id);
            Console.WriteLine("Done!");
        }
    }
}
