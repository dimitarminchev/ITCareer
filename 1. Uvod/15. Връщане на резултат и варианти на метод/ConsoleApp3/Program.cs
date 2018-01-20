using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        // 03. По-голямата от две стойности

        // Метод който сравнява две цели числа (int)
        static void GetMax(int a,int b) 
        {
            Console.WriteLine( Math.Max(a,b) );
        }
        // Метод който сравнява два знака (char)
        static void GetMax(char a, char b) 
        {
            var max = a;
            if (b > max) max = b;
            Console.WriteLine(max);
        }
        // Метод който сравнява два низа (string)
        static void GetMax(string a, string b)  
        {
            int c = string.Compare(a, b); 
            if(c > 0) Console.WriteLine(a);
            else Console.WriteLine(b);
        }

        // Главен метод
        static void Main(string[] args)
        {
            var type = Console.ReadLine(); // int, char, string
            var a = Console.ReadLine(); // string
            var b = Console.ReadLine(); // string
            switch(type)
            {
                case "int": GetMax(int.Parse(a), int.Parse(b)); break;
                case "char":
                {
                        char a1 = a[0], b1 = b[0]; // първи знак от низа
                        GetMax(a1,b1); break;
                }
                case "string": GetMax(a, b); break;
            }
            
        }
    }
}
