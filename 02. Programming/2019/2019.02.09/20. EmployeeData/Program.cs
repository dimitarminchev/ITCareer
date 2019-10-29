using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.EmployeeData
{
    class Program
    {
        // 20. Данни за служител
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalID = long.Parse(Console.ReadLine()); 
            int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalID}");
            Console.WriteLine($"Unique Employee number: {uniqueEmployeeNumber}");
        }
    }
}
