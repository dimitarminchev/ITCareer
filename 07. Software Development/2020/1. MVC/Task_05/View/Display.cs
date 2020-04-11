using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05.View
{
    public class Display
    {
        public double priceOfVegetables { get; set; }
        public double priceOfFruit { get; set; }
        public int kilosVegetables { get; set; }
        public int kilosFruits { get; set; }
        public double total { get; set; }

        public Display()
        {
            this.priceOfFruit = 0;
            this.priceOfVegetables = 0;
            this.kilosFruits = 0;
            this.kilosVegetables = 0;
            this.total = 0;
            GetValues();
        }

        public void GetValues()
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

        public void ShowResult()
        {
            Console.WriteLine(total);
        }

    }
}
