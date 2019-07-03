using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _415
{
    class Program
    {
        // Автор: Цветилин Цветилов
        static void Main(string[] args)
        {
/*
956 989 1037 1095
948 992 1025 1062 1160
*/            
            int[] day1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] day2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] result = day1.Concat(day2).ToArray().OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
