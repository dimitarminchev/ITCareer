using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // 1. Учебна зала
        static void Main(string[] args)
        {
            // Входни данни
            var w = double.Parse(Console.ReadLine()) * 100;
            var h = double.Parse(Console.ReadLine()) * 100;

            // Математически сметки
            var w1 = (int)w / 120;
            var h1 = ((int)h - 100) / 70;
            var r = w1 * h1 - 3;

            // Изходни данни
            Console.WriteLine(r);
        }
    }
}
