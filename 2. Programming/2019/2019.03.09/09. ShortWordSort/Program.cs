using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ShortWordSort
{
    class Program
    {
        static void Main(string[] args)
        {            
            // Разделители
            var separators = new char[] 
            {
                '.',',',':',';','(',')','[',']','"','\'','\\','/','!','?',' '
            };            

            var input   = Console.ReadLine()            // Четем ред от конзолата                        
                        .Split(separators, 
                         StringSplitOptions.RemoveEmptyEntries) // Разделяме на части
                        .Select(word => word.ToLower()) // Само малки букви                        
                        .ToList();                      // Правим списък

            var output  = input.Where(x => x.Length<5)  // Тези думи по-малко от 5 знака
                        .Distinct()                     // Без повторения 
                        .OrderBy(x => x)                // Сортиране в намаляващ ред
                        .ToList();                      // Правим списък

            Console.WriteLine(String.Join(", ", output));
        }
    }
}
