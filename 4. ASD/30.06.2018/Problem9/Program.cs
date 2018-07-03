using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class Program
    {
        /* Problem 9. Remove/Add Method 
        Определете сложността (максимания брой стъпки) на програма, която чете от конзолата 
        възходящ списък от цели числа на един ред, разделени с интервал и на втори ред число, 
        за което се проверява дали е в списъка или не. Ако е, то то се премахва от него , 
        а ако го няма – се добавя на такова място, че списъка отново да е подреден. 
        Изведете: Новополучения списък и Двата списъка – входния и новополучения.
        */
        static void Main(string[] args)
        {
            List<int> NumbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            NumbersList.Sort();

            Console.WriteLine(String.Join(" ", NumbersList));

            int num = int.Parse(Console.ReadLine());
            if (!NumbersList.Exists(p => p.Equals(num))) NumbersList.Add(num);
            else  NumbersList.Remove(num);
 
            Console.WriteLine(String.Join(" ", NumbersList));

            // Total: O(N*ln(N))
        }
    }
}
