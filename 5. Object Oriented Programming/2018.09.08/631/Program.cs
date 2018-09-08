using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _631
{
    class Program
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            Console.WriteLine
            (
                spy.StealFieldInfo
                (
                    "Hacker.Hacker", 
                    new string[] 
                    {
                        "username",
                        "password"
                    }
                )
            );
        }
    }
}
