using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _511
{
    public class Search
    {        
        public static int Linear<T>(T[] elements, T key) where T : IComparable
        {
            for (int index = 0; index < elements.Count(); index++)
            {
                if (elements[index].CompareTo(key) == 0)
                {
                    return index; // Found
                }
            }
            return -1; // Not Found
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            index = Search.Linear(numbers, n);
            if(index == -1)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
