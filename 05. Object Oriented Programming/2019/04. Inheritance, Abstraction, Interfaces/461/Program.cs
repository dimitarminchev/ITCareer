using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _461
{
    class Program
    {
        static void Main(string[] args)
        {
             ContractEmployee employee = new ContractEmployee("Math Problems","Second Floor","Gosho","0123","Sliven");
            employee.Show();
            Console.WriteLine( employee.CalculateSalary(48));
        }
    }
}
