using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        // 15. Операции между числа 
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            if (op == "+")
            {
                Console.Write("{0} + {1} = {2} - ", n1, n2, n1 + n2);
                Console.WriteLine((n1 + n2) % 2 == 0 ? "even" : "odd");
            }
            else if (op == "-")
            {
                Console.Write("{0} - {1} = {2} - ", n1, n2, n1 - n2);
                Console.WriteLine((n1 + n2) % 2 == 0 ? "even" : "odd");
            }
            else if (op == "*")
            {
                Console.Write("{0} * {1} = {2} - ", n1, n2, n1 * n2);
                Console.WriteLine((n1 + n2) % 2 == 0 ? "even" : "odd");
            }
            else if (op == "/")
            {
                if(n2==0) Console.WriteLine("Cannot divide {0} by zero", n1);
                else Console.WriteLine("{0} / {1} = {2} - ", n1, n2, (double)n1 / n2);
            }
            else if (op == "%")
            {
                if (n2 == 0) Console.WriteLine("Cannot divide {0} by zero", n1);
                else Console.WriteLine("{0} % {1} = {2} - ", n1, n2, n1 % n2);
            }

        }
    }
}
