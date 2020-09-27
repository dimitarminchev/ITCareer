using System;

namespace _1._Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Създаваме три обекта инстанции на класа 
            Point a = new Point(2, 3);
            Point b = new Point(3, 2);
            Point c = new Point(4, 4);

            // Калкулираме и отпечатваме хеш на обектите
            Console.WriteLine("Point {0}, Hash = {1}", a.ToString(), a.GetHashCode());
            Console.WriteLine("Point {0}, Hash = {1}", b.ToString(), b.GetHashCode());
            Console.WriteLine("Point {0}, Hash = {1}", c.ToString(), c.GetHashCode());
        }
    }
}
