using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "Close")
            {
                switch (command[0])
                {
                    case "Sell":
                        ManageProducts.Sell(command[1], double.Parse(command[2]));
                        break;
                    case "Add":
                        ManageProducts.Add(command[1], command[2], double.Parse(command[3]), double.Parse(command[4]));
                        break;
                    case "Update":
                        ManageProducts.Update(command[1], double.Parse(command[2]));
                        break;
                    case "PrintA":
                        ManageProducts.PrintA();
                        break;
                    case "PrintU":
                        ManageProducts.PrintU();
                        break;
                    case "PrintD":
                        ManageProducts.PrintD();
                        break;
                    case "Calculate":
                        ManageProducts.Calculate();
                        break;
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
