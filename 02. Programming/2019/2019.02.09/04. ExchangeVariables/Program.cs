using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExchangeVariables
{
    class Program
    {
        // 4. Размяна на стойности на променливи
        static void Main(string[] args)
        {
            // Декларираме две целочислени променливи и им присвояваме стойности
            int a = 5, b = 10;
            Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);
            // Размяна на стойностите на двете промеливи
            int temp = a;
            a = b;
            b = temp;
            // Отпечатване на разменените стойностите
            Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
        }
    }
}
