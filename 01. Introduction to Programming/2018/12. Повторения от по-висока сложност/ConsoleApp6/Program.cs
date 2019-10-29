using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Пирамида от числа
            int n = int.Parse(Console.ReadLine());
            int br = 1; 
            for(int k=1;k<=n;k++)
            {
                int temp = k;
                for(int j=br; temp > 0;j++,temp--)
                {                    
                    Console.Write(j + " ");
                    if (j == n) return;
                    br++;
                }
                Console.WriteLine();      
            }
        }
    }
}
