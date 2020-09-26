using System;

namespace _4._BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Създаване на двоично дърво
            BinaryTree tree = new BinaryTree();

            // Добавяне на елементи към дървото
            var items = new int[] { 17, 9, 6, 12, 19, 25 };
            foreach (var item in items)
            {
                tree.Add(item);
            }

            // Отпечатване на елементите на вървото
            BinaryTreePrinter.Print(tree.Root);
        }
    }
}
