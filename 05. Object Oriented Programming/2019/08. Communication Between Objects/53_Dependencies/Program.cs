using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_Dependencies
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimitiveCalculator calculator = new PrimitiveCalculator();
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "End")
            {
                try
                {
                    int firstOperand = int.Parse(command[0]);
                    int secondOperand = int.Parse(command[1]);
                    Console.WriteLine(calculator.performCalculation(firstOperand, secondOperand));
                }
                catch
                {
                    calculator.changeStrategy(command[1].First());
                }
                command = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
