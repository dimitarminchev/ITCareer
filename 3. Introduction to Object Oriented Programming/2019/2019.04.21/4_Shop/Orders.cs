using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Shop
{
    class Orders
    {
        // Поръчки
        private static Dictionary<Product, double> orders;

        // Конструктор
        static Orders()
        {
            orders = new Dictionary<Product, double>();
        }

        // Добавяне на продукт
        public static void Add(string barcode, string name, double price, double quantity)
        {
            Product product = new Product(name, barcode, price);
            if (orders.ContainsKey(product))
            {
                orders[product] += quantity;
            }
            else
            {
                orders.Add(product, quantity);
            }
        }

        // Продажба на продукт
        public static void Sell(string barcode, double quantity)
        {
            // Проверяваме дали продукта съществува
            if (!orders.ContainsKey(orders.First(item => item.Key.Barcode == barcode).Key))
            {
                throw new ArgumentException("Please add your product first");
            }
            var product = orders.First(item => item.Key.Barcode == barcode).Key;
            // Проверяваме наличността на продукта
            if (orders[product] < quantity)
            {
                throw new ArgumentException("Not enough quantity");
            }
            orders[product] -= quantity;

        }

        // Зареждане на продукт
        public static void Update(string barcode, double quantity)
        {
            // Проверяваме дали продукта съществува
            if (!orders.ContainsKey(orders.First(item => item.Key.Barcode == barcode).Key))
            {
                throw new ArgumentException("Please add your product first");
            }
            var product = orders.First(item => item.Key.Barcode == barcode).Key;
            orders[product] += quantity;
        }

        // Отпчатване на продуктите наредени по име на продукта
        public static void PrintA()
        {
            var items = orders.OrderBy(item => item.Key.Name);
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key.Name} ({item.Key.Barcode})");
            }
        }

        // Отпчатване на неналичните продукти
        public static void PrintU()
        {
            var items = orders.Where(item => item.Value == 0);
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key.Name} ({item.Key.Barcode})");
            }
        }

        // Отпечатване на продуктите по намаляваща стойност
        public static void PrintD()
        {
            var items = orders.OrderByDescending(item => item.Value);
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key.Name} ({item.Key.Barcode})");
            }
        }

        // Изчисляване на стойността на всички налични продукти 
        public static double Calculate()
        {
            double total = 0;
            foreach (var order in orders)
            {
                total += order.Key.Price * order.Value;
            }
            return total;
        }

    }
}
