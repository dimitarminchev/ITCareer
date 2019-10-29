using System;
using System.Collections.Generic;
namespace Task_09
{
/* 9. Въвеждане на списък от конзолата
Въведете списък от цели числа и го изведете в конзолата:
*/
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            for (int index = 0; index < list.Count; index++)
            {
                Console.WriteLine("list[{0}] = {1}", index, list[index]);
            }
        }
    }
}
