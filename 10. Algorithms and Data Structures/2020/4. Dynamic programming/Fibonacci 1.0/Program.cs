using System;
using System.Collections.Generic;

namespace Fibonacci_1._0
{
    class Program
    {
        // Редица на Фибоначи
        static List<int> fib = new List<int>();

        static void Main(string[] args)
        {
            // Вход
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            // Изход
            int a = 1, b = 1, c = a + b;

            // Добавяме първите три елемента в списъка
            fib.Add(a); fib.Add(b); fib.Add(c);

            // Обхождаме до N
            for (int i = 0; i < n-3; i++)
            {
                // Метод на плаващия прозорец
                a = b;
                b = c;
                c = a + b;
                // добавяме следващия получен елемент
                fib.Add(c);
            }

            // Отпечатваме резултата
            Console.WriteLine(string.Join(", ", fib));
        }
    }
}
