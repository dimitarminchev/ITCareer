using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CenturiesToMinutes
{
    class Program
    {
        // 1. Векове към минути 
        static void Main(string[] args)
        {
            Console.Write("Centuries = ");
            byte centuries = byte.Parse(Console.ReadLine());
            // Сметки
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 356.2422);
            ulong hours = 24 * days;
            ulong minutes = 60 * hours;
            // Отпечатаме
            Console.WriteLine
            (
                "{0} centuries = {1} years = {2} days = {3} hours = {4} minutes",
                centuries, years, days, hours, minutes
            );
        }
    }
}
