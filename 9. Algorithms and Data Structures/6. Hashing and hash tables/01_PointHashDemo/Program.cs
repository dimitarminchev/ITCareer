using System;

namespace _01_PointHashDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Points
            Point a = new Point(2, 3);
            Point b = new Point(3, 2);
            Point c = new Point(4, 4);
            
            // Hashes
            Console.WriteLine("Point {0}, Hash = {1}", a, a.GetHashCode());
            Console.WriteLine("Point {0}, Hash = {1}", b, b.GetHashCode());
            Console.WriteLine("Point {0}, Hash = {1}", c, c.GetHashCode());
        }
    }
}
