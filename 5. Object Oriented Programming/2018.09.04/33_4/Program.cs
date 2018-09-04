using System;

namespace _33_4
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>();
            list.Add("42");
            list.Add("21");
            list.Add("15");
            list.Sort();
            Console.WriteLine(list.ToString());
        }
    }
}
