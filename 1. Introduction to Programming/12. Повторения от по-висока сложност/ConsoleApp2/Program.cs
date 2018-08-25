using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Сумиране на цифрите на число
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while(n > 0)
            {
                sum += n % 10;  
                n /= 10;        
            }
            Console.WriteLine(sum);
        }
    }
}
