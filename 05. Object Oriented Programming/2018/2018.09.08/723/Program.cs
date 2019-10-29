using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _723
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            words = words.Where(n => n[0].ToString() == n[0].ToString().ToUpper()).ToArray();
            Console.WriteLine(string.Join("\n",words));
        }
    }
}
