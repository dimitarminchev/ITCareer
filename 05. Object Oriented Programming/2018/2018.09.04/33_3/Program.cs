using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_3
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> lis = new CustomList<int>();
            lis.Add(33);
            lis.Add(22);
            lis.Add(11);
            lis.Sort();
            Console.WriteLine(lis.ToString());
        }
    }
}
