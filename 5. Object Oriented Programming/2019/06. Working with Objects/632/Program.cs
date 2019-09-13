using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _632
{
    class Program
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string newResult = spy.AnalyzeAcessModifiers("Hacker");
            Console.WriteLine(newResult);
        }
    }
}
