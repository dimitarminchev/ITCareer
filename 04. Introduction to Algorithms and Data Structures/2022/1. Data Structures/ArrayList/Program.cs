using System;
namespace ArrayList 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Разтеглив масив с цели числа
            ArrayList<int> arrayList = new ArrayList<int>();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);

            // Отпечатване
            // foreach (var item in arraylist)
            // {
            //    console.writeline("{0} ", item);
            // }
            Console.WriteLine(string.Join(" ",arrayList));

            // Разтеглив масив с низове
            ArrayList<string> stringList = new ArrayList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            Console.WriteLine(string.Join(" ", stringList));

        }
    }
}