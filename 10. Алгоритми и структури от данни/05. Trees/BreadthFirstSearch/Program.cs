﻿namespace BreadthFirstSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Създаване на дървовидна структура
            Tree<int> tree = new Tree<int>
            (
                7,
                new Tree<int>
                (
                    19,
                    new Tree<int>(1),
                    new Tree<int>(12),
                    new Tree<int>(31)
                ),
                new Tree<int>(21),
                new Tree<int>
                (
                    14,
                    new Tree<int>(23),
                    new Tree<int>(6)
                )
            );

            // Отпечатване на дървовидната структура
            tree.Print();

            //  Обхождане на дървовидната структура в широчина
            Console.WriteLine("Breadth First Search (BFS): {0}", string.Join(" ", tree.BFS()));
        }
    }
}