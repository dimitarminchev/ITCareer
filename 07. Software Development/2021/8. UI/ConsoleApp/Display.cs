namespace ConsoleApp
{
    using System;
    using Business;
    using Data.Model;

    /// <summary>
    /// Console User Interface (UI)
    /// </summary>
    public class Display
    {
        private int closeOperationId = 6;

        private ProductBusiness productBusiness = new ProductBusiness();

        /// <summary>
        ///  Constructor
        /// </summary>
        public Display()
        {
            Input();
        }

        /// <summary>
        /// Menu UI
        /// </summary>
        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new entry");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Fetch entry by ID");
            Console.WriteLine("5. Delete entry by ID");
            Console.WriteLine("6. Exit");
        }

        /// <summary>
        /// User Input
        /// </summary>
        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
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
                        break;
                }
            } while (operation != closeOperationId);
        }

        /// <summary>
        /// US for Deletion
        /// </summary>
        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            productBusiness.Delete(id);
            Console.WriteLine("Done.");
        }

        /// <summary>
        /// UI for getting a single product record from the database
        /// </summary>
        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productBusiness.Get(id);
            if (product != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price: " + product.Price);
                Console.WriteLine("Stock: " + product.Stock);
                Console.WriteLine(new string('-', 40));
            }
        }

        /// <summary>
        /// UI dor updating a single product record in the database.
        /// </summary>
        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productBusiness.Get(id);
            if (product != null)
            {
                Console.WriteLine("Enter name: ");
                product.Name = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                product.Price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter availability: ");
                product.Stock = int.Parse(Console.ReadLine());
                productBusiness.Update(product);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        /// <summary>
        /// UI for adding a single product record to the database.
        /// </summary>
        private void Add()
        {
            Product product = new Product();
            Console.WriteLine("Enter name: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            product.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter availability: ");
            product.Stock = int.Parse(Console.ReadLine());
            productBusiness.Add(product);
        }

        /// <summary>
        /// UI to list all the products.
        /// </summary>
        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "PRODUCTS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var products = productBusiness.GetAll();
            foreach (var item in products)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.Id, item.Name, item.Price, item.Stock);
            }
        }
    }
}
