using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StringExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Input
            Console.WriteLine("Please Enter a String:");
            var str = Console.ReadLine();

            // Use StringExtention Class
            Console.WriteLine("MD5: {0}", StringExtensions.ToMd5Hash(str));
            Console.WriteLine("Bool: {0}", StringExtensions.ToBoolean(str));
            Console.WriteLine("Int: {0}", StringExtensions.ToInteger(str));
            Console.WriteLine("Long: {0}", StringExtensions.ToLong(str));
            // etc.
        }
    }
}
