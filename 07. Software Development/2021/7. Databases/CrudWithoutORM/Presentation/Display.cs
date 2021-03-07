namespace CrudWithoutORM.Presentation
{
    using System;
    using System.Linq;
    using CrudWithoutORM.Business;
    using CrudWithoutORM.Common;

    public class Display
    {
        private int closeOperationId = 6;

        private ProductBussiness productBussiness = new ProductBussiness();

        /// <summary>
        /// Constructor
        /// </summary>
        public Display()
        {
            Input();
        }

        /// <summary>
        /// Show Menu
        /// </summary>
        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string('-', 18) + "MENU" + new string('-', 18));
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
            ShowMenu();
            do
            {
                operation = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (operation)
                {
                    case 1: ListAll(); break;
                    case 2: Add(); break;
                    case 3: Update(); break;
                    case 4: Fetch(); break;
                    case 5: Delete(); break;
                }
                ShowMenu();
            } while (operation != closeOperationId);
        }
        
        /// <summary>
        /// Add new product
        /// </summary>
        public void Add()
        {
            Product product = new Product();
            Console.WriteLine("Enter name: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Enter price:");
            product.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter stock: ");
            product.Stock = int.Parse(Console.ReadLine());
            productBussiness.Add(product);
        }

        /// <summary>
        /// Get all products from the datanase
        /// </summary>
        public void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string('-', 16) + "PRODUCTS" + new string('-', 16));
            Console.WriteLine(new string('-', 40));
            var products = productBussiness.GetAll();
            if (products.Count() == 0)
            {
                Console.WriteLine("No products available!");
            }
            else
            {
                foreach (var item in products)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Price}$ {item.Stock}");
                }
            }
        }

        /// <summary>
        /// Update product by Id
        /// </summary>
        private void Update()
        {
            Console.Write("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productBussiness.Get(id);
            if (product != null)
            {
                Console.Write("Enter name: ");
                product.Name = Console.ReadLine();
                Console.Write("Enter price: ");
                product.Price = decimal.Parse(Console.ReadLine());
                Console.Write("Enter stock: ");
                product.Stock = int.Parse(Console.ReadLine());
                productBussiness.Update(product);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        /// <summary>
        /// Fech information fot single product
        /// </summary>
        public void Fetch()
        {
            Console.WriteLine("Enter ID to fecth: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productBussiness.Get(id);
            if (product != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine($"ID: {product.Id}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price}$");
                Console.WriteLine($"Stock: {product.Stock}");
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        /// <summary>
        /// Delete a product from the database by Id
        /// </summary>
        public void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            if (productBussiness.Delete(id))
            {
                Console.WriteLine("The product is deleted.");
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }
    }
}
