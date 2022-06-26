using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3214
{
    class Program
    {
/*      3.2.14. Мажорант на масив
        ---
        Мажорант на масив от N елемента е стойност, която се среща поне N/2+1 пъти. Напишете програма, която по даден масив от числа намира мажоранта на масива и го отпечатва. Ако мажоранта не съществува – отпечатва "The majorant does not exists!”.
        Вход	                              Изход
        2, 2, 3, 3, 2, 3, 4, 3, 3	          3
        2, 3, 4, 5, 6, 7, 8, 3	              The majorant does not exists!
*/
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int res = list.Where(x => list.Count(c => c == x) >= list.Count() / 2 + 1).ToList().Distinct().FirstOrDefault();
            if (res != 0) Console.WriteLine(res);
            else Console.WriteLine("The majorant does not exists!”.");
        }
    }
}
