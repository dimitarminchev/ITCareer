using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // 01. Празна касова бележка

        // Header
        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        // Body
        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        // Footer
        private static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }

        // Receipt
        private static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        // Main
        static void Main(string[] args)
        {
            PrintReceipt();
        }
    }
}
