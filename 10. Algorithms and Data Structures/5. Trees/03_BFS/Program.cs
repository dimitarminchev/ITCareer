using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BFS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tree 
            Tree<int> tree =
                new Tree<int>
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

            // BFS
            var ordered = tree.BFS();
            Console.WriteLine(string.Format("BFS: {0}", string.Join(", ", ordered)));

        }
    }
}
