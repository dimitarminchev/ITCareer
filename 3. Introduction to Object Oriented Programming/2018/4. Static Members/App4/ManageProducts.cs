using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class ManageProducts
    {
        private static List<Product> products = new List<Product>();
        public static void Sell(string barcode, double soldQuantity)
        {
            int indexOfProduct = -1;
            for(int i=0;i<products.Count;i++)
            {
                if(products[i].Barcode==barcode)
                {
                    indexOfProduct = i;
                    break;
                }
            }
            if (indexOfProduct == -1 || products[indexOfProduct].Quantity < soldQuantity)
            {
                Console.WriteLine("Not enough quantity");
            }
            else products[indexOfProduct].Quantity -= soldQuantity;
        }
        public static void Add(string barcode,string name,double price,double quantity)
        {
            products.Add(new Product { Barcode = barcode, Name = name, Price = price, Quantity = quantity });
        }
        public static void Update(string barcode, double quantity)
        {
            int indexOfProduct = -1;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Barcode == barcode)
                {
                    indexOfProduct = i;
                    break;
                }
            }
            if (indexOfProduct == -1) Console.WriteLine("Please add your product first!");
            else products[indexOfProduct].Quantity += quantity;
        }
        public static void PrintA()
        {
            foreach(var product in products.OrderBy(x=>x.Name))
            {
                if (product.Quantity > 0)
                {
                    Console.WriteLine($"{product.Name} ({product.Barcode})");
                }
            }
        }
        public static void PrintU()
        {
            foreach(var product in products.OrderBy(x=>x.Name))
            {
                if (product.Quantity == 0)
                {
                    Console.WriteLine($"{product.Name} ({product.Barcode})");
                }
            }
        }
        public static void PrintD()
        {
            foreach (var product in products.OrderByDescending(x => x.Quantity))
            {
                Console.WriteLine($"{product.Name} ({product.Barcode})");
            }
        }
        public static void Calculate()
        {
            double worthOfProducts = 0;
            for(int i=0;i<products.Count;i++)
            {
                worthOfProducts += products[i].Price * products[i].Quantity;
            }
            Console.WriteLine($"{worthOfProducts:f2}");
        }
    }
}
