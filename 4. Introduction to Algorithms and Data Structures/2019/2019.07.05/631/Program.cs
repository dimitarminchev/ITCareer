using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _631
{
    class Program
    {
        //631* = Words
        public static List<string> final = new List<string>();
        public static int Counter=0;
        public static bool distincted = true;
        public static void CheckWord(char[]s)
        {
            bool go = true;
            for (int i = 0; i < s.Length - 1; i ++)
            {
                if (s[i] == s[i + 1])
                {
                    go = false;
                    break;
                }
            }
            if (go)
            {
                if (distincted) Counter++;
                else
                {
                    final.Add(string.Join("", s));
                    final = final.Distinct().ToList();
                }
            }
        }
        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;
            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void GetPermutation(char[] list)
        {
            int x = list.Length - 1;
            GetPermutation(list, 0, x);
        }

        private static void GetPermutation(char[] list, int k, int m)
        {
            if (k == m)
            {
                CheckWord(list);
                //Console.WriteLine(list);
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPermutation(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            if (arr.Count() != arr.Distinct().Count()) distincted = false;
            GetPermutation(arr);
            if (distincted) Console.WriteLine(Counter);
            else Console.WriteLine(final.Count());
        }
    }
}
