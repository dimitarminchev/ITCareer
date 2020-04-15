using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        /// <summary>
        /// Main Mathod of the Program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Number
            int n = int.Parse(Console.ReadLine());

            // Refactoring of a Method
            PrintUserInfo(n-1);
            PrintUserInfo(n);
            PrintUserInfo(n+1);
        }

        /// <summary>
        /// Print the user info to the Console
        /// </summary>
        /// <param name="n">N parameter</param>
        private static void PrintUserInfo(int n)
        {
            // Print
            Console.WriteLine("n*2={0}", n * 2);
            Console.WriteLine("n+2={0}", n + 2);
            Console.WriteLine("n/2 + 2*n={0}", n / 2 + 2 * n);
        }
    }
}
