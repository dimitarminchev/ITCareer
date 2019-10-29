using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _622
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Foundation", 1951, "Isac Asimov");

            Console.WriteLine(bookOne.ToString());
            Console.WriteLine(bookTwo.ToString());
            Console.WriteLine(bookThree.ToString());
        }
    }
}
