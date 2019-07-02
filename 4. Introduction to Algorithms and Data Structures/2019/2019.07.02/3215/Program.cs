using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3215
{
    class Program
    {
/*      Problem 15. Мода на масив
        ---
        Мода на масив от N елемента е стойност, която се среща най-често. Напишете програма, която по даден масив от числа намира модата на масива и го отпечатва. Ако има няколко моди се извежда средно аритметичната им стойност

        Вход	                            Изход
        2, 2, 3, 3, 2, 3, 4, 3, 3		    3 
        3, 3, 4, 5, 6, 7, 4, 2, 2	        6 
 */
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool moreThanOne = false;
            int maxCount = 0;
            int number = -1;
            foreach (var item in list)
            {
                int counter = list.Count(c => c == item);
                if (counter >= maxCount && number != item)
                {
                    if (counter == maxCount && !moreThanOne)
                    {
                        moreThanOne = true;
                    }
                    else
                    {
                        maxCount = counter;
                        number = item;
                    }
                }
            }
            double mod = 0;
            if (moreThanOne)
            {
                mod = (double)list.Where(x => list.Count(c => c == x) == maxCount).ToList().Distinct().Sum() / maxCount;
            }
            else
            {
                mod = number;
            }
            Console.WriteLine(mod);
        }
    }
}
/*
var list = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var dic = new Dictionary<int, int>();
            foreach (var item in list)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }
            var val = dic.Values.OrderByDescending(x => x).ToList();
            var sum = 0;
             var del = 0;
            foreach (var item in dic.Keys)
            {
                if (dic[item] == val[0])
                {
                    sum += item;
                    del =dic[item];
                }                
            }
            Console.WriteLine($"{sum/(double)del}");
*/
