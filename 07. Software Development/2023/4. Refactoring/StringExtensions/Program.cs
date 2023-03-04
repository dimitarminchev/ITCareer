using System.Reflection.Metadata;

namespace StringExtensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String to MD5 demo
            var md5 = StringExtensions.ToMd5Hash("Hello World");
            Console.WriteLine(md5);

            // String To DateTime demo
            var dt = StringExtensions.ToDateTime("4/3/2023");
            Console.WriteLine(dt);
            
            // etc...
        }
    }
}