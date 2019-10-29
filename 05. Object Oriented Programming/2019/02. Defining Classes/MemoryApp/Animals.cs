using System;
using System.Collections.Generic;

namespace MemoryApp
{
    // Animal
    public class Animal
    {
        public string name { get; set; }
        public int age { get; set; }
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    // Animals
    public class Animals : IDisposable
    {
        // Animals List
        public List<Animal> animals;

        // Add Animal
        public void Add(Animal animal)
        {
            this.animals.Add(animal);
            Animals.count++;
        }

        // Counter
        private static int count = 0;

        public static int Count
        {
            get { return count; }
        }

        // Constructor
        public Animals()
        {
            this.animals = new List<Animal>();            
            Console.WriteLine("Constructor");
        }

        // Finalizer
        ~Animals()
        {
            Console.WriteLine("Finalizer");
        }

        // Dispozer
        public void Dispose()
        {
            Console.WriteLine("Dispozer");
            this.animals = null;
        }
    }
}
