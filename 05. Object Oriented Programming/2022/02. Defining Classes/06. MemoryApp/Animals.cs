using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._MemoryApp
{
    /// <summary>
    /// Живoтно
    /// </summary>
    public class Animal
    {
        public string name { get; set; }
        public int age { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    /// <summary>
    /// Животни
    /// </summary>
    public class Animals : IDisposable
    {
        public List<Animal> animals = null;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Animals()
        {
            this.animals = new List<Animal>();
            Console.WriteLine("Constuctor");
        }

        /// <summary>
        /// Деструктор
        /// </summary>
        ~Animals()
        {
            this.animals = null;
            Console.WriteLine("Finalizer"); // Garbage Collector
        }

        /// <summary>
        /// Disposer
        /// </summary>
        public void Dispose()
        {
            this.animals = null;
            Console.WriteLine("Disposer");
        }

        private static int count;

        /// <summary>
        /// Брой на животните
        /// </summary>
        public static int Count
        {
            get { return count; }
        }

        /// <summary>
        /// Добавяне на животно
        /// </summary>
        public void Add(Animal animal)
        {
            this.animals.Add(animal);
            Animals.count++;
        }
        
    }
}
