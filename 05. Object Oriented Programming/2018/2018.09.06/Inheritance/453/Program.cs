using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _453
{
    public class Program
    {

        public static void WriteLine(object text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void Main()
        {
            var sAc = new SitesAndCalls();
            ICall call = sAc;
            call.Call(Console.ReadLine().Split(' '));
            IBrowse browse = sAc;
            browse.Browse(Console.ReadLine().Split(' '));
        }
    }

    interface ICall
    {
        void Call(string[] numbers);
    }

    interface IBrowse
    {
        void Browse(string[] sites);
    }

    class SitesAndCalls : ICall, IBrowse
    {
        public void Browse(string[] sites)
        {
            for (int i = 0; i < sites.Length; i++)
                if (sites[i].Any(a => char.IsNumber(a)))
                    Program.WriteLine("Invalid URL!");
                else
                    Program.WriteLine("Browsing: " + sites[i]);
        }

        public void Call(string[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                if (ulong.TryParse(numbers[i], out ulong useless))
                    Program.WriteLine("Calling... " + numbers[i]);
                else
                    Program.WriteLine("Invalid number!");
        }
    }
}