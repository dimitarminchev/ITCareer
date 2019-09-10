using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryApp
{
    class Program
    {
        // Memory App
        static void Main(string[] args)
        {
            // Create Animals Instance
            Animals animals = new Animals();

            // Add Animals
            animals.Add(new Animal("Krocodile", 70));
            animals.Add(new Animal("Turle", 200));
            animals.Add(new Animal("Pig", 12));
            animals.Add(new Animal("Snake", 7));

            // Animals Count
            Console.WriteLine("Animals Count = {0}", Animals.Count);

            // Dispose Animals Instance
            animals.Dispose();
        }
    }
}
