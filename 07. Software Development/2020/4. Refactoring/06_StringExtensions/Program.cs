using System;

namespace StringExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Please Enter a String:");
            var str = Console.ReadLine();

            // StringExtention Demo
            Console.WriteLine("MD5: {0}", StringExtensions.ToMd5Hash(str));
            Console.WriteLine("Bool: {0}", StringExtensions.ToBoolean(str));
            Console.WriteLine("Int: {0}", StringExtensions.ToInteger(str));
            Console.WriteLine("Long: {0}", StringExtensions.ToLong(str));
 
        }
    }
}
