using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ComparableBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);
            Library library = new Library(bookOne, bookTwo, bookThree);

            // Print
            foreach (var item in library) Console.WriteLine(item);
        }
    }
}
