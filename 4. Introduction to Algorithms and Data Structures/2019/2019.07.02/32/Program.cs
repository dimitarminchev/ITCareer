using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    class Program
    {
        // Обединение
        public static List<int> Union( List<int> firstList, List<int> secondList)
        {
            List<int> union = new List<int>();
            union.AddRange(firstList);
            foreach (var item in secondList)
            {
                if (!union.Contains(item))
                {
                    union.Add(item);
                }
            }
            return union;
        }

        // Сечение
        public static List<int> Intersect( List<int> firstList, List<int> secondList)
        {
            List<int> intersect = new List<int>();
            foreach (var item in firstList)
            {
                if (secondList.Contains(item))
                {
                    intersect.Add(item);
                }
            }
            return intersect;
        }

        // Печат
        public static void PrintList(List<int> list)
        {
            Console.Write("{ ");
            foreach (var item in list)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine("}");
        }


        public static void Main()
        {
            // Първи списък
            List<int> firstList = new List<int>();
            firstList.Add(1); firstList.Add(2); firstList.Add(3); firstList.Add(4); firstList.Add(5);
            Console.Write("firstList = ");
            PrintList(firstList);

            // Втори списък
            List<int> secondList = new List<int>();
            secondList.Add(2); secondList.Add(4);
            secondList.Add(6);
            Console.Write("secondList = ");
            PrintList(secondList);

            // Обединение
            List<int> unionList = Union(firstList, secondList);
            Console.Write("union = ");
            PrintList(unionList);

            // Сечение
            List<int> intersectList = Intersect(firstList, secondList);
            Console.Write("intersect = ");
            PrintList(intersectList);
        }

    }
}
