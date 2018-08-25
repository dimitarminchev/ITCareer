using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        // Главен метод
        static void Main(string[] args)
        {
            // Създаваме първи обект инстанция на класа
            Person Ivan = new Person();
            Ivan.Name = "Ivan Ivanov";
            Ivan.Age = 23;
            Ivan.IntroduceYourself();

            // Създаваме втори обект инстанция на класа
            Person Pesho = new Person();
            Pesho.Name = "Peter Petrov";
            Pesho.Age = 6;
            Pesho.IntroduceYourself();
        }
    }
}
