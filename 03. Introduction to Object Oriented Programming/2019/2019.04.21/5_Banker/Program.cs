using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Banker
{
    class Program
    {
        static void Main(string[] args)
        {
/* 
Deposit 101 103.25
Deposit 102 205.41
Withdraw 101 202.56
Withdraw 102 101.45
Withdraw 103 10.45
Print
Close 
*/
            // Input
            var cmd = Console.ReadLine().Split().ToArray();
            while (cmd[0] != "Close")
            {
                try
                {
                    switch (cmd[0])
                    {
                        case "Deposit":
                            Bank.Deposit(int.Parse(cmd[1]), double.Parse(cmd[2]));
                            break;
                        case "Withdraw":
                            Bank.Withdraw(int.Parse(cmd[1]), double.Parse(cmd[2]));
                            break;
                        case "Print":
                            Bank.Print();
                            break;
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                cmd = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
