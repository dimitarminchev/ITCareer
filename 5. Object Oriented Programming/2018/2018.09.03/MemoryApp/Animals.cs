using System;
using System.Collections.Generic;

namespace MemoryApp
{
    // Животно
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
    // Животни
    public class Animals : IDisposable // Наследяване
    {
        // Списък
        public List<Animal> animals;

        // Добавяне
        public void Add(Animal anime)
        {
            animals.Add(anime);
        }

        // Конструктор
        public Animals()
        {
            animals = new List<Animal>(); // heap
            Console.WriteLine("Constructor");
        }

        // Деструктор
        ~Animals()
        {
            Console.WriteLine("Destructor");                  
        }

        // Имплементация на интерфейс
        public void Dispose()
        {
            Console.WriteLine("Dispose");

            // Освобождаване на заетата памет
            this.animals = null;           
        }
    }
}
