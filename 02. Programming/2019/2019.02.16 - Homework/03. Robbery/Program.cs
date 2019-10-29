using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Robbery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //ne sa pishe tei
            int jelleweryPrice = numbers[0];
            int goldPrice = numbers[1];
            string command = Console.ReadLine();
            int earnings = 0;
            while (command != "Jail Time")
            {
                string[] loot = command.Split(' ').ToArray();
                int loss = int.Parse(loot[1]);
                string profit = loot[0].ToString();
                for (int i = 0; i < profit.Length; i++)
                    switch (profit[i])
                    {
                        case '%': earnings += jelleweryPrice; break;
                        case '$': earnings += goldPrice; break;
                        default: earnings += 0; break;
                    }
                earnings -= loss;
                command = Console.ReadLine();
            }
            if (earnings >= 0)
                Console.WriteLine($"Heiss will continue. Total earnings: {earnings}.");
            else
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(earnings)}.");
        }
    }
}
