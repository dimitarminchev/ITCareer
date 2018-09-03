using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Създаваме обект инстанция на класа "Човечето"
            Person firstPerson = new Person();

            // Задаваме свойствата на обекта
            firstPerson.Name = "Гошо";
            firstPerson.Age = 15;

            // Изпълняваме метод от класа
            firstPerson.IntroduceYourself();
        }
    }
}
