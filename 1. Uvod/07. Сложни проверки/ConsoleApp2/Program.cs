using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Квартално магазинче
            var продукт = Console.ReadLine().ToLower();
            var град = Console.ReadLine().ToLower();
            var брой = double.Parse(Console.ReadLine());
            // Проверки по град
            if(град == "sofia")
            {
                switch (продукт)
                {
                    case "coffee": { Console.WriteLine(брой * 0.50); break; }
                    case "water": { Console.WriteLine(брой * 0.80); break; }
                    case "beer": { Console.WriteLine(брой * 1.20); break; }
                    case "sweets": { Console.WriteLine(брой * 1.45); break; }
                    case "peanuts": { Console.WriteLine(брой * 1.60); break; }
                }
            }
            if (град == "plovdiv")
            {
                switch (продукт)
                {
                    case "coffee": { Console.WriteLine(брой * 0.40); break; }
                    case "water": { Console.WriteLine(брой * 0.70); break; }
                    case "beer": { Console.WriteLine(брой * 1.15); break; }
                    case "sweets": { Console.WriteLine(брой * 1.30); break; }
                    case "peanuts": { Console.WriteLine(брой * 1.50); break; }
                }
            }
            if (град == "varna")
            {
                switch (продукт)
                {
                    case "coffee": { Console.WriteLine(брой * 0.45); break; }
                    case "water": { Console.WriteLine(брой * 0.70); break; }
                    case "beer": { Console.WriteLine(брой * 1.10); break; }
                    case "sweets": { Console.WriteLine(брой * 1.35); break; }
                    case "peanuts": { Console.WriteLine(брой * 1.55); break; }
                }
            }

        }
    }
}
