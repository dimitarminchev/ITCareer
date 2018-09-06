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
            BaseEmployee employee0 = new FullTimeEmployee("1223445", "HTML", "DRujba", "tovarach", "basic");
            BaseEmployee employee1 = new ContractEmployee("56877586", "CSS", "Centar", "kominochistach", "Advanced");
            employee0.CalculateSalary(356 * 12);
            employee1.CalculateSalary(356 * 12);
        }
    }
}
