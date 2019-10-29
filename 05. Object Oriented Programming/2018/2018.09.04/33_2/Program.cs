using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> lis = new CustomList<int>();
            lis.Add(1);
            lis.Add(2);
            lis.Add(3);
            Console.WriteLine(lis.CountGreaterThan(1));
            Console.WriteLine(lis.Min());
            Console.WriteLine(lis.Max());
            lis.Swap(1, 2);
            Console.WriteLine(lis.ToString());
        }
    }
}
