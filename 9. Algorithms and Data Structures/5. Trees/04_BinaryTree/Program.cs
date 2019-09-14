using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Binary Tree
            BinaryTree tree = new BinaryTree();

            // Add Items to the Binary Tree
            var items = new int[] { 17, 9, 6, 12, 19, 25 };
            foreach (var item in items)
            {
                tree.Add(item);
            }

            // Print the Binary Tree
            BinaryTreePrinter.Print(tree.Root);
            
        }
    }
}
